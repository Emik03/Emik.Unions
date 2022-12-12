// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent RedundantCast RedundantLinebreak UnusedMemberInSuper.Global
// <copyright file="Product.Overloads.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Tagged;
#pragma warning disable CA1000, CA1033, RCS1036, RCS1232
/// <summary>Defines an inheritable record that automates logic for a union.</summary>
/// <typeparam name="T1">The first type of the union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Product<T1, TType> : IProduct<T1>
    where TType : Product<T1, TType>
{
    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(a => a.GetGetMethod() is not null)
       .ToArray();

    static readonly Func<T1, TType> s_factory = Factories.From<T1, TType>().Expect();

    readonly string? _ex;

    /// <summary>Initializes a new instance of the <see cref="Product{T1, TType}"/> class.</summary>
    /// <remarks><para>Using this constructor means that any state is considered valid.</para></remarks>
    protected Product() { }

    /// <summary>Initializes a new instance of the <see cref="Product{T1, TType}"/> class.</summary>
    /// <param name="first">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="second">The second condition to assert. True is a valid state.</param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="third">The third condition to assert. True is a valid state.</param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourth">The fourth condition to assert. True is a valid state.</param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    protected Product(
        bool first,
        bool second = true,
        bool third = true,
        bool fourth = true,
        [CallerArgumentExpression(nameof(first))] string? firstEx = null,
        [CallerArgumentExpression(nameof(second))] string? secondEx = null,
        [CallerArgumentExpression(nameof(third))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourth))] string? fourthEx = null)
        =>
            _ex =
            !first ? firstEx :
            !second ? secondEx :
            !third ? thirdEx :
            !fourth ? fourthEx :
            null;

    /// <summary>Initializes a new instance of the <see cref="Product{T1, TType}"/> class.</summary>
    /// <param name="first">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="second">The second condition to assert. True is a valid state.</param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="third">The third condition to assert. True is a valid state.</param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourth">The fourth condition to assert. True is a valid state.</param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    /// <exception cref="InvalidCastException">The inheriting record is not <typeparamref name="TType"/>.</exception>
    protected Product(
        [RequireStaticDelegate] Predicate<TType>? first,
        [RequireStaticDelegate] Predicate<TType>? second = null,
        [RequireStaticDelegate] Predicate<TType>? third = null,
        [RequireStaticDelegate] Predicate<TType>? fourth = null,
        [CallerArgumentExpression(nameof(first))] string? firstEx = null,
        [CallerArgumentExpression(nameof(second))] string? secondEx = null,
        [CallerArgumentExpression(nameof(third))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourth))] string? fourthEx = null)
        =>
            _ex =
            !first?.Invoke((TType)this) ?? false ? firstEx :
            !second?.Invoke((TType)this) ?? false ? secondEx :
            !third?.Invoke((TType)this) ?? false ? thirdEx :
            !fourth?.Invoke((TType)this) ?? false ? fourthEx :
            null;

    static readonly Converter<TType, T1> s_firstGetter =
        (Converter<TType, T1>)Delegate.CreateDelegate(
            typeof(Converter<TType, T1>),
            s_properties[0].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T1 IProduct<T1>.First => s_firstGetter((TType)this);

    /// <summary>Attempts to create a new instance of <typeparamref name="TType"/>.</summary>
    /// <param name="first">The first value of the union.</param>
    /// <returns>A new instance of <typeparamref name="TType"/> which encapsulates all of the parameters.</returns>
    [MustUseReturnValue]
#pragma warning disable MA0018, SA1114 // Normally a code smell, but is meant to be inherited anyway.
    public static Result<TType, Fault<TType>> New(
        T1 first)
#pragma warning restore MA0018, SA1114
    {
        var that = s_factory(
            first);

        return that._ex is { } ex ? new Fault<TType>(ex, that) : that;
    }

    /// <inheritdoc/>
    [Pure]
    IReadOnlyList<PropertyInfo> IProperties.Properties => s_properties.ToReadOnly();

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 0)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc/>
    [Pure]
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc/>
    [LinqTunnel, Pure]
    IEnumerator<KeyValuePair<PropertyInfo, object?>> IPropertyEnumerable.Enumeration()
    {
        yield return new(s_properties[0], s_firstGetter((TType)this));
    }
}

/// <summary>Defines an inheritable record that automates logic for a union.</summary>
/// <typeparam name="T1">The first type of the union.</typeparam>
/// <typeparam name="T2">The second type of the union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Product<T1, T2, TType> : IProduct<T1, T2>
    where TType : Product<T1, T2, TType>
{
    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(a => a.GetGetMethod() is not null)
       .ToArray();

    static readonly Func<T1, T2, TType> s_factory = Factories.From<T1, T2, TType>().Expect();

    readonly string? _ex;

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, TType}"/> class.</summary>
    /// <remarks><para>Using this constructor means that any state is considered valid.</para></remarks>
    protected Product() { }

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, TType}"/> class.</summary>
    /// <param name="first">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="second">The second condition to assert. True is a valid state.</param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="third">The third condition to assert. True is a valid state.</param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourth">The fourth condition to assert. True is a valid state.</param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    protected Product(
        bool first,
        bool second = true,
        bool third = true,
        bool fourth = true,
        [CallerArgumentExpression(nameof(first))] string? firstEx = null,
        [CallerArgumentExpression(nameof(second))] string? secondEx = null,
        [CallerArgumentExpression(nameof(third))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourth))] string? fourthEx = null)
        =>
            _ex =
            !first ? firstEx :
            !second ? secondEx :
            !third ? thirdEx :
            !fourth ? fourthEx :
            null;

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, TType}"/> class.</summary>
    /// <param name="first">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="second">The second condition to assert. True is a valid state.</param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="third">The third condition to assert. True is a valid state.</param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourth">The fourth condition to assert. True is a valid state.</param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    /// <exception cref="InvalidCastException">The inheriting record is not <typeparamref name="TType"/>.</exception>
    protected Product(
        [RequireStaticDelegate] Predicate<TType>? first,
        [RequireStaticDelegate] Predicate<TType>? second = null,
        [RequireStaticDelegate] Predicate<TType>? third = null,
        [RequireStaticDelegate] Predicate<TType>? fourth = null,
        [CallerArgumentExpression(nameof(first))] string? firstEx = null,
        [CallerArgumentExpression(nameof(second))] string? secondEx = null,
        [CallerArgumentExpression(nameof(third))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourth))] string? fourthEx = null)
        =>
            _ex =
            !first?.Invoke((TType)this) ?? false ? firstEx :
            !second?.Invoke((TType)this) ?? false ? secondEx :
            !third?.Invoke((TType)this) ?? false ? thirdEx :
            !fourth?.Invoke((TType)this) ?? false ? fourthEx :
            null;

    static readonly Converter<TType, T1> s_firstGetter =
        (Converter<TType, T1>)Delegate.CreateDelegate(
            typeof(Converter<TType, T1>),
            s_properties[0].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T1 IProduct<T1, T2>.First => s_firstGetter((TType)this);

    static readonly Converter<TType, T2> s_secondGetter =
        (Converter<TType, T2>)Delegate.CreateDelegate(
            typeof(Converter<TType, T2>),
            s_properties[1].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T2 IProduct<T1, T2>.Second => s_secondGetter((TType)this);

    /// <summary>Attempts to create a new instance of <typeparamref name="TType"/>.</summary>
    /// <param name="first">The first value of the union.</param>
    /// <param name="second">The second value of the union.</param>
    /// <returns>A new instance of <typeparamref name="TType"/> which encapsulates all of the parameters.</returns>
    [MustUseReturnValue]
#pragma warning disable MA0018, SA1114 // Normally a code smell, but is meant to be inherited anyway.
    public static Result<TType, Fault<TType>> New(
        T1 first,
        T2 second)
#pragma warning restore MA0018, SA1114
    {
        var that = s_factory(
            first,
            second);

        return that._ex is { } ex ? new Fault<TType>(ex, that) : that;
    }

    /// <inheritdoc/>
    [Pure]
    IReadOnlyList<PropertyInfo> IProperties.Properties => s_properties.ToReadOnly();

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 1)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc/>
    [Pure]
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc/>
    [LinqTunnel, Pure]
    IEnumerator<KeyValuePair<PropertyInfo, object?>> IPropertyEnumerable.Enumeration()
    {
        yield return new(s_properties[0], s_firstGetter((TType)this));
        yield return new(s_properties[1], s_secondGetter((TType)this));
    }
}

/// <summary>Defines an inheritable record that automates logic for a union.</summary>
/// <typeparam name="T1">The first type of the union.</typeparam>
/// <typeparam name="T2">The second type of the union.</typeparam>
/// <typeparam name="T3">The third type of the union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Product<T1, T2, T3, TType> : IProduct<T1, T2, T3>
    where TType : Product<T1, T2, T3, TType>
{
    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(a => a.GetGetMethod() is not null)
       .ToArray();

    static readonly Func<T1, T2, T3, TType> s_factory = Factories.From<T1, T2, T3, TType>().Expect();

    readonly string? _ex;

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, T3, TType}"/> class.</summary>
    /// <remarks><para>Using this constructor means that any state is considered valid.</para></remarks>
    protected Product() { }

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, T3, TType}"/> class.</summary>
    /// <param name="first">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="second">The second condition to assert. True is a valid state.</param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="third">The third condition to assert. True is a valid state.</param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourth">The fourth condition to assert. True is a valid state.</param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    protected Product(
        bool first,
        bool second = true,
        bool third = true,
        bool fourth = true,
        [CallerArgumentExpression(nameof(first))] string? firstEx = null,
        [CallerArgumentExpression(nameof(second))] string? secondEx = null,
        [CallerArgumentExpression(nameof(third))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourth))] string? fourthEx = null)
        =>
            _ex =
            !first ? firstEx :
            !second ? secondEx :
            !third ? thirdEx :
            !fourth ? fourthEx :
            null;

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, T3, TType}"/> class.</summary>
    /// <param name="first">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="second">The second condition to assert. True is a valid state.</param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="third">The third condition to assert. True is a valid state.</param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourth">The fourth condition to assert. True is a valid state.</param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    /// <exception cref="InvalidCastException">The inheriting record is not <typeparamref name="TType"/>.</exception>
    protected Product(
        [RequireStaticDelegate] Predicate<TType>? first,
        [RequireStaticDelegate] Predicate<TType>? second = null,
        [RequireStaticDelegate] Predicate<TType>? third = null,
        [RequireStaticDelegate] Predicate<TType>? fourth = null,
        [CallerArgumentExpression(nameof(first))] string? firstEx = null,
        [CallerArgumentExpression(nameof(second))] string? secondEx = null,
        [CallerArgumentExpression(nameof(third))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourth))] string? fourthEx = null)
        =>
            _ex =
            !first?.Invoke((TType)this) ?? false ? firstEx :
            !second?.Invoke((TType)this) ?? false ? secondEx :
            !third?.Invoke((TType)this) ?? false ? thirdEx :
            !fourth?.Invoke((TType)this) ?? false ? fourthEx :
            null;

    static readonly Converter<TType, T1> s_firstGetter =
        (Converter<TType, T1>)Delegate.CreateDelegate(
            typeof(Converter<TType, T1>),
            s_properties[0].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T1 IProduct<T1, T2, T3>.First => s_firstGetter((TType)this);

    static readonly Converter<TType, T2> s_secondGetter =
        (Converter<TType, T2>)Delegate.CreateDelegate(
            typeof(Converter<TType, T2>),
            s_properties[1].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T2 IProduct<T1, T2, T3>.Second => s_secondGetter((TType)this);

    static readonly Converter<TType, T3> s_thirdGetter =
        (Converter<TType, T3>)Delegate.CreateDelegate(
            typeof(Converter<TType, T3>),
            s_properties[2].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T3 IProduct<T1, T2, T3>.Third => s_thirdGetter((TType)this);

    /// <summary>Attempts to create a new instance of <typeparamref name="TType"/>.</summary>
    /// <param name="first">The first value of the union.</param>
    /// <param name="second">The second value of the union.</param>
    /// <param name="third">The third value of the union.</param>
    /// <returns>A new instance of <typeparamref name="TType"/> which encapsulates all of the parameters.</returns>
    [MustUseReturnValue]
#pragma warning disable MA0018, SA1114 // Normally a code smell, but is meant to be inherited anyway.
    public static Result<TType, Fault<TType>> New(
        T1 first,
        T2 second,
        T3 third)
#pragma warning restore MA0018, SA1114
    {
        var that = s_factory(
            first,
            second,
            third);

        return that._ex is { } ex ? new Fault<TType>(ex, that) : that;
    }

    /// <inheritdoc/>
    [Pure]
    IReadOnlyList<PropertyInfo> IProperties.Properties => s_properties.ToReadOnly();

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 2)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc/>
    [Pure]
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc/>
    [LinqTunnel, Pure]
    IEnumerator<KeyValuePair<PropertyInfo, object?>> IPropertyEnumerable.Enumeration()
    {
        yield return new(s_properties[0], s_firstGetter((TType)this));
        yield return new(s_properties[1], s_secondGetter((TType)this));
        yield return new(s_properties[2], s_thirdGetter((TType)this));
    }
}

/// <summary>Defines an inheritable record that automates logic for a union.</summary>
/// <typeparam name="T1">The first type of the union.</typeparam>
/// <typeparam name="T2">The second type of the union.</typeparam>
/// <typeparam name="T3">The third type of the union.</typeparam>
/// <typeparam name="T4">The fourth type of the union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Product<T1, T2, T3, T4, TType> : IProduct<T1, T2, T3, T4>
    where TType : Product<T1, T2, T3, T4, TType>
{
    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(a => a.GetGetMethod() is not null)
       .ToArray();

    static readonly Func<T1, T2, T3, T4, TType> s_factory = Factories.From<T1, T2, T3, T4, TType>().Expect();

    readonly string? _ex;

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, T3, T4, TType}"/> class.</summary>
    /// <remarks><para>Using this constructor means that any state is considered valid.</para></remarks>
    protected Product() { }

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, T3, T4, TType}"/> class.</summary>
    /// <param name="first">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="second">The second condition to assert. True is a valid state.</param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="third">The third condition to assert. True is a valid state.</param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourth">The fourth condition to assert. True is a valid state.</param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    protected Product(
        bool first,
        bool second = true,
        bool third = true,
        bool fourth = true,
        [CallerArgumentExpression(nameof(first))] string? firstEx = null,
        [CallerArgumentExpression(nameof(second))] string? secondEx = null,
        [CallerArgumentExpression(nameof(third))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourth))] string? fourthEx = null)
        =>
            _ex =
            !first ? firstEx :
            !second ? secondEx :
            !third ? thirdEx :
            !fourth ? fourthEx :
            null;

    /// <summary>Initializes a new instance of the <see cref="Product{T1, T2, T3, T4, TType}"/> class.</summary>
    /// <param name="first">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="second">The second condition to assert. True is a valid state.</param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="third">The third condition to assert. True is a valid state.</param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourth">The fourth condition to assert. True is a valid state.</param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    /// <exception cref="InvalidCastException">The inheriting record is not <typeparamref name="TType"/>.</exception>
    protected Product(
        [RequireStaticDelegate] Predicate<TType>? first,
        [RequireStaticDelegate] Predicate<TType>? second = null,
        [RequireStaticDelegate] Predicate<TType>? third = null,
        [RequireStaticDelegate] Predicate<TType>? fourth = null,
        [CallerArgumentExpression(nameof(first))] string? firstEx = null,
        [CallerArgumentExpression(nameof(second))] string? secondEx = null,
        [CallerArgumentExpression(nameof(third))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourth))] string? fourthEx = null)
        =>
            _ex =
            !first?.Invoke((TType)this) ?? false ? firstEx :
            !second?.Invoke((TType)this) ?? false ? secondEx :
            !third?.Invoke((TType)this) ?? false ? thirdEx :
            !fourth?.Invoke((TType)this) ?? false ? fourthEx :
            null;

    static readonly Converter<TType, T1> s_firstGetter =
        (Converter<TType, T1>)Delegate.CreateDelegate(
            typeof(Converter<TType, T1>),
            s_properties[0].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T1 IProduct<T1, T2, T3, T4>.First => s_firstGetter((TType)this);

    static readonly Converter<TType, T2> s_secondGetter =
        (Converter<TType, T2>)Delegate.CreateDelegate(
            typeof(Converter<TType, T2>),
            s_properties[1].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T2 IProduct<T1, T2, T3, T4>.Second => s_secondGetter((TType)this);

    static readonly Converter<TType, T3> s_thirdGetter =
        (Converter<TType, T3>)Delegate.CreateDelegate(
            typeof(Converter<TType, T3>),
            s_properties[2].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T3 IProduct<T1, T2, T3, T4>.Third => s_thirdGetter((TType)this);

    static readonly Converter<TType, T4> s_fourthGetter =
        (Converter<TType, T4>)Delegate.CreateDelegate(
            typeof(Converter<TType, T4>),
            s_properties[3].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T4 IProduct<T1, T2, T3, T4>.Fourth => s_fourthGetter((TType)this);

    /// <summary>Attempts to create a new instance of <typeparamref name="TType"/>.</summary>
    /// <param name="first">The first value of the union.</param>
    /// <param name="second">The second value of the union.</param>
    /// <param name="third">The third value of the union.</param>
    /// <param name="fourth">The fourth value of the union.</param>
    /// <returns>A new instance of <typeparamref name="TType"/> which encapsulates all of the parameters.</returns>
    [MustUseReturnValue]
#pragma warning disable MA0018, SA1114 // Normally a code smell, but is meant to be inherited anyway.
    public static Result<TType, Fault<TType>> New(
        T1 first,
        T2 second,
        T3 third,
        T4 fourth)
#pragma warning restore MA0018, SA1114
    {
        var that = s_factory(
            first,
            second,
            third,
            fourth);

        return that._ex is { } ex ? new Fault<TType>(ex, that) : that;
    }

    /// <inheritdoc/>
    [Pure]
    IReadOnlyList<PropertyInfo> IProperties.Properties => s_properties.ToReadOnly();

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 3)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc/>
    [Pure]
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc/>
    [LinqTunnel, Pure]
    IEnumerator<KeyValuePair<PropertyInfo, object?>> IPropertyEnumerable.Enumeration()
    {
        yield return new(s_properties[0], s_firstGetter((TType)this));
        yield return new(s_properties[1], s_secondGetter((TType)this));
        yield return new(s_properties[2], s_thirdGetter((TType)this));
        yield return new(s_properties[3], s_fourthGetter((TType)this));
    }
}

