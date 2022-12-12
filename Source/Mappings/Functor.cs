// <copyright file="Functor.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Mappings;

using static BindingFlags;

/// <summary>Defines a functor of unspecified types.</summary>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Functor<TType>
    where TType : Functor<TType>
{
    const BindingFlags Bindings = DeclaredOnly | Static | Public | NonPublic;

    static TType? s_instance;

    /// <summary>
    /// Initializes a new instance of the <see cref="Functor{TType}"/> class by updating <see cref="Instance"/>.
    /// </summary>
    protected Functor() => s_instance = (TType)this;

    /// <summary>
    /// Gets or sets the method used to create an instance of <typeparamref name="TType"/> without parameters.
    /// This is meant to be set in a static constructor to intercept the creation of <see cref="Instance"/>.
    /// </summary>
    [Pure]
    protected static Func<TType> New { get; set; } = OverridenNew();

    /// <summary>Gets the shared instance.</summary>
    protected static TType Instance
    {
        [MustUseReturnValue] get => s_instance ?? New();
    }

    [Pure]
    static bool IsRoot(Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Functor<>);

    [MustUseReturnValue]
    static Func<TType> CallAndValidate(PropertyInfo property) =>
        property.GetValue(null, null) as Func<TType> ?? throw new InvalidOperationException();

    [MustUseReturnValue]
    static Func<TType> OverridenNew()
    {
        var type = typeof(TType);

        do
            if (type.GetProperty(nameof(New), Bindings) is { } property)
                return CallAndValidate(property);
        while (type.BaseType is { } t && !IsRoot(type = t));

        throw new MissingMethodException(typeof(TType).Name, nameof(New));
    }
}

/// <summary>Defines a type that acts as a functor and <c>newtype</c> idiom from Rust simultaneously.</summary>
/// <typeparam name="T">The type that can be converted into this type.</typeparam>
/// <typeparam name="TResult">The resulting type that encapsulates this type.</typeparam>
/// <typeparam name="TType">The type of the implementor.</typeparam>
/// <param name="Converter">The converting function that creates this instance, much like <c>From</c> in Rust.</param>
public abstract record Functor<T, TResult, TType>(Converter<T, TResult> Converter) : Functor<TType>,
    IFunctor<T, TType>,
    IProduct<TResult, Converter<T, TResult>>
    where TType : Functor<T, TResult, TType>
{
    /// <inheritdoc cref="Functor{TType}.New"/>
    [Pure]
#pragma warning disable CS8604
    protected new static Func<TType> New => () => s_factory(default);
#pragma warning restore CS8604

    static readonly Func<TResult, TType> s_factory = Factories.From<TResult, TType>().Expect();

    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | Public)
       .Where(x => x.GetGetMethod() is not null && x.GetSetMethod() is not null)
       .ToArray();

    static readonly Converter<TType, TResult> s_getter = (Converter<TType, TResult>)Delegate.CreateDelegate(
        typeof(Converter<TType, TResult>),
        s_properties[0].GetGetMethod() ?? throw new MissingMethodException(typeof(TType).Name, "any property")
    );

    /// <inheritdoc />
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc />
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 1)] int index] => this.Index(index);

    /// <inheritdoc />
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc />
    TResult IProduct<TResult, Converter<T, TResult>>.First => this;

    /// <inheritdoc />
    public Converter<T, TType> Factory => x => s_factory(Converter(x));

    /// <inheritdoc />
    IReadOnlyList<PropertyInfo> IProperties.Properties => s_properties.ToReadOnly();

    /// <inheritdoc />
    Converter<T, TResult> IProduct<TResult, Converter<T, TResult>>.Second => Converter;

    /// <summary>Gets the encapsulated value.</summary>
    /// <param name="functor">The value encapsulating an inner value.</param>
    /// <returns>The inner value of the parameter <paramref name="functor"/>.</returns>
    public static implicit operator TResult(Functor<T, TResult, TType> functor) => s_getter((TType)functor);

    /// <summary>Maps this instance to another functor.</summary>
    /// <typeparam name="TFunctor">The resulting value.</typeparam>
    /// <returns>
    /// The instance of <typeparamref name="TFunctor"/> from the mapping of <typeparamref name="TType"/>.
    /// </returns>
    public TFunctor To<TFunctor>()
        where TFunctor : Functor<TFunctor>, IFunctor<TResult, TFunctor> =>
        Functor<TFunctor>.Instance.Factory(this);

    /// <inheritdoc />
    IEnumerator<KeyValuePair<PropertyInfo, object?>> IPropertyEnumerable.Enumeration()
    {
        yield return new(s_properties[0], (TResult)this);
        yield return new(s_properties[1], Converter);
    }
}
