// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent RedundantCast RedundantLinebreak UnusedMemberInSuper.Global
// <copyright file="Either.Overloads.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Disjoints;
#pragma warning disable CA1000, CA1033, RCS1036, SA1508
/// <summary>Defines a disjoint union with implicit conversions, for parameter signatures.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <param name="First">The first value of the disjoint union.</param>
/// <param name="Second">The second value of the disjoint union.</param>
public sealed record Overload<T1, T2>(T1? First, T2? Second)
    : Either<T1, T2, Overload<T1, T2>>
    where T1 : notnull
    where T2 : notnull
{
    /// <inheritdoc cref="Either{T1, T2, TType}.New(T1)" />
    public static implicit operator Overload<T1, T2>(T1 first) => New(first);

    /// <inheritdoc cref="IEither{T1, T2}.First" />
    public static explicit operator T1?(Overload<T1, T2> first) => ((IEither<T1, T2>)first).First;

    /// <inheritdoc cref="Either{T1, T2, TType}.New(T2)" />
    public static implicit operator Overload<T1, T2>(T2 second) => New(second);

    /// <inheritdoc cref="IEither{T1, T2}.Second" />
    public static explicit operator T2?(Overload<T1, T2> second) => ((IEither<T1, T2>)second).Second;

}

/// <summary>Defines a disjoint union with implicit conversions, for parameter signatures.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <param name="First">The first value of the disjoint union.</param>
/// <param name="Second">The second value of the disjoint union.</param>
/// <param name="Third">The third value of the disjoint union.</param>
public sealed record Overload<T1, T2, T3>(T1? First, T2? Second, T3? Third)
    : Either<T1, T2, T3, Overload<T1, T2, T3>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
{
    /// <inheritdoc cref="Either{T1, T2, T3, TType}.New(T1)" />
    public static implicit operator Overload<T1, T2, T3>(T1 first) => New(first);

    /// <inheritdoc cref="IEither{T1, T2, T3}.First" />
    public static explicit operator T1?(Overload<T1, T2, T3> first) => ((IEither<T1, T2, T3>)first).First;

    /// <inheritdoc cref="Either{T1, T2, T3, TType}.New(T2)" />
    public static implicit operator Overload<T1, T2, T3>(T2 second) => New(second);

    /// <inheritdoc cref="IEither{T1, T2, T3}.Second" />
    public static explicit operator T2?(Overload<T1, T2, T3> second) => ((IEither<T1, T2, T3>)second).Second;

    /// <inheritdoc cref="Either{T1, T2, T3, TType}.New(T3)" />
    public static implicit operator Overload<T1, T2, T3>(T3 third) => New(third);

    /// <inheritdoc cref="IEither{T1, T2, T3}.Third" />
    public static explicit operator T3?(Overload<T1, T2, T3> third) => ((IEither<T1, T2, T3>)third).Third;

}

/// <summary>Defines a disjoint union with implicit conversions, for parameter signatures.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
/// <param name="First">The first value of the disjoint union.</param>
/// <param name="Second">The second value of the disjoint union.</param>
/// <param name="Third">The third value of the disjoint union.</param>
/// <param name="Fourth">The fourth value of the disjoint union.</param>
public sealed record Overload<T1, T2, T3, T4>(T1? First, T2? Second, T3? Third, T4? Fourth)
    : Either<T1, T2, T3, T4, Overload<T1, T2, T3, T4>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
{
    /// <inheritdoc cref="Either{T1, T2, T3, T4, TType}.New(T1)" />
    public static implicit operator Overload<T1, T2, T3, T4>(T1 first) => New(first);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4}.First" />
    public static explicit operator T1?(Overload<T1, T2, T3, T4> first) => ((IEither<T1, T2, T3, T4>)first).First;

    /// <inheritdoc cref="Either{T1, T2, T3, T4, TType}.New(T2)" />
    public static implicit operator Overload<T1, T2, T3, T4>(T2 second) => New(second);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4}.Second" />
    public static explicit operator T2?(Overload<T1, T2, T3, T4> second) => ((IEither<T1, T2, T3, T4>)second).Second;

    /// <inheritdoc cref="Either{T1, T2, T3, T4, TType}.New(T3)" />
    public static implicit operator Overload<T1, T2, T3, T4>(T3 third) => New(third);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4}.Third" />
    public static explicit operator T3?(Overload<T1, T2, T3, T4> third) => ((IEither<T1, T2, T3, T4>)third).Third;

    /// <inheritdoc cref="Either{T1, T2, T3, T4, TType}.New(T4)" />
    public static implicit operator Overload<T1, T2, T3, T4>(T4 fourth) => New(fourth);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4}.Fourth" />
    public static explicit operator T4?(Overload<T1, T2, T3, T4> fourth) => ((IEither<T1, T2, T3, T4>)fourth).Fourth;

}

#if !NET35
/// <summary>Defines a disjoint union with implicit conversions, for parameter signatures.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
/// <typeparam name="T5">The fifth type of the disjoint union.</typeparam>
/// <param name="First">The first value of the disjoint union.</param>
/// <param name="Second">The second value of the disjoint union.</param>
/// <param name="Third">The third value of the disjoint union.</param>
/// <param name="Fourth">The fourth value of the disjoint union.</param>
/// <param name="Fifth">The fifth value of the disjoint union.</param>
public sealed record Overload<T1, T2, T3, T4, T5>(T1? First, T2? Second, T3? Third, T4? Fourth, T5? Fifth)
    : Either<T1, T2, T3, T4, T5, Overload<T1, T2, T3, T4, T5>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
{
    /// <inheritdoc cref="Either{T1, T2, T3, T4, T5, TType}.New(T1)" />
    public static implicit operator Overload<T1, T2, T3, T4, T5>(T1 first) => New(first);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4, T5}.First" />
    public static explicit operator T1?(Overload<T1, T2, T3, T4, T5> first) => ((IEither<T1, T2, T3, T4, T5>)first).First;

    /// <inheritdoc cref="Either{T1, T2, T3, T4, T5, TType}.New(T2)" />
    public static implicit operator Overload<T1, T2, T3, T4, T5>(T2 second) => New(second);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4, T5}.Second" />
    public static explicit operator T2?(Overload<T1, T2, T3, T4, T5> second) => ((IEither<T1, T2, T3, T4, T5>)second).Second;

    /// <inheritdoc cref="Either{T1, T2, T3, T4, T5, TType}.New(T3)" />
    public static implicit operator Overload<T1, T2, T3, T4, T5>(T3 third) => New(third);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4, T5}.Third" />
    public static explicit operator T3?(Overload<T1, T2, T3, T4, T5> third) => ((IEither<T1, T2, T3, T4, T5>)third).Third;

    /// <inheritdoc cref="Either{T1, T2, T3, T4, T5, TType}.New(T4)" />
    public static implicit operator Overload<T1, T2, T3, T4, T5>(T4 fourth) => New(fourth);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4, T5}.Fourth" />
    public static explicit operator T4?(Overload<T1, T2, T3, T4, T5> fourth) => ((IEither<T1, T2, T3, T4, T5>)fourth).Fourth;

    /// <inheritdoc cref="Either{T1, T2, T3, T4, T5, TType}.New(T5)" />
    public static implicit operator Overload<T1, T2, T3, T4, T5>(T5 fifth) => New(fifth);

    /// <inheritdoc cref="IEither{T1, T2, T3, T4, T5}.Fifth" />
    public static explicit operator T5?(Overload<T1, T2, T3, T4, T5> fifth) => ((IEither<T1, T2, T3, T4, T5>)fifth).Fifth;

}

#endif
