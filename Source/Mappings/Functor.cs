// <copyright file="Functor.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Mappings;

/// <summary>Defines a type that acts as a functor and <c>newtype</c> idiom from Rust simultaneously.</summary>
/// <typeparam name="T">The type that can be converted into this type.</typeparam>
/// <typeparam name="TResult">The resulting type that encapsulates this type.</typeparam>
/// <typeparam name="TType">The type of the implementor.</typeparam>
/// <param name="Converter">The converting function that creates this instance, much like <c>From</c> in Rust.</param>
public abstract record Functor<T, TResult, TType>(Converter<T, TResult> Converter) : SharedInstance<TType>,
    IFunctor<T, TType>
    where TType : Functor<T, TResult, TType>
{
    static readonly Func<TResult, TType> s_factory = Factories.From<TResult, TType>().Expect();

    static readonly Converter<TType, TResult> s_getter =
        (Converter<TType, TResult>)Delegate.CreateDelegate(
            typeof(Converter<TType, TResult>),
            typeof(TType)
               .GetProperties(BindingFlags.Instance | BindingFlags.Public)
               .Select(x => x.GetGetMethod())
               .FirstOrDefault(x => x is not null) ??
            throw new MissingMethodException(typeof(TType).Name, "any getter")
        );

    /// <inheritdoc />
    public Converter<T, TType> Factory => x => s_factory(Converter(x));

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
        where TFunctor : SharedInstance<TFunctor>, IFunctor<TResult, TFunctor> =>
        SharedInstance<TFunctor>.Instance.Factory(this);

    static Functor()
    {
        if (!HasInstance)
#pragma warning disable CS8604
            _ = s_factory(default);
#pragma warning restore CS8604
    }
}
