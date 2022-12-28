// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent RedundantCast RedundantLinebreak UnusedMemberInSuper.Global
// <copyright file="Either.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Disjoints;
#pragma warning disable RCS1036, SA1508
/// <summary>A static class that provides methods for creating new instances of disjoint union types.</summary>
public static class Either
{
    /// <summary>
    /// Creates a <see cref="IEither{T1, T2}"/> with the inner value <typeparamref name="T1"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <param name="first">
    /// The parameter to pass in the type <see cref="IEither{T1, T2}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2}"/> with <paramref name="first"/>.</returns>
    [Pure]
    public static IEither<T1, T2> New<T1, T2>(T1 first)
        =>
            new InnerEither<T1, T2>(first);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2}"/> with the inner value <typeparamref name="T2"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <param name="second">
    /// The parameter to pass in the type <see cref="IEither{T1, T2}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2}"/> with <paramref name="second"/>.</returns>
    [Pure]
    public static IEither<T1, T2> New<T1, T2>(T2 second)
        =>
            new InnerEither<T1, T2>(second);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3}"/> with the inner value <typeparamref name="T1"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="first">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3}"/> with <paramref name="first"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3> New<T1, T2, T3>(T1 first)
        =>
            new InnerEither<T1, T2, T3>(first);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3}"/> with the inner value <typeparamref name="T2"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="second">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3}"/> with <paramref name="second"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3> New<T1, T2, T3>(T2 second)
        =>
            new InnerEither<T1, T2, T3>(second);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3}"/> with the inner value <typeparamref name="T3"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="third">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3}"/> with <paramref name="third"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3> New<T1, T2, T3>(T3 third)
        =>
            new InnerEither<T1, T2, T3>(third);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4}"/> with the inner value <typeparamref name="T1"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <param name="first">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4}"/> with <paramref name="first"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4> New<T1, T2, T3, T4>(T1 first)
        =>
            new InnerEither<T1, T2, T3, T4>(first);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4}"/> with the inner value <typeparamref name="T2"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <param name="second">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4}"/> with <paramref name="second"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4> New<T1, T2, T3, T4>(T2 second)
        =>
            new InnerEither<T1, T2, T3, T4>(second);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4}"/> with the inner value <typeparamref name="T3"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <param name="third">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4}"/> with <paramref name="third"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4> New<T1, T2, T3, T4>(T3 third)
        =>
            new InnerEither<T1, T2, T3, T4>(third);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4}"/> with the inner value <typeparamref name="T4"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <param name="fourth">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4}"/> with <paramref name="fourth"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4> New<T1, T2, T3, T4>(T4 fourth)
        =>
            new InnerEither<T1, T2, T3, T4>(fourth);

#if !NET35
    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4, T5}"/> with the inner value <typeparamref name="T1"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T5">
    /// The fifth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <param name="first">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4, T5}"/> with <paramref name="first"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4, T5> New<T1, T2, T3, T4, T5>(T1 first)
        =>
            new InnerEither<T1, T2, T3, T4, T5>(first);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4, T5}"/> with the inner value <typeparamref name="T2"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T5">
    /// The fifth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <param name="second">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4, T5}"/> with <paramref name="second"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4, T5> New<T1, T2, T3, T4, T5>(T2 second)
        =>
            new InnerEither<T1, T2, T3, T4, T5>(second);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4, T5}"/> with the inner value <typeparamref name="T3"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T5">
    /// The fifth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <param name="third">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4, T5}"/> with <paramref name="third"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4, T5> New<T1, T2, T3, T4, T5>(T3 third)
        =>
            new InnerEither<T1, T2, T3, T4, T5>(third);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4, T5}"/> with the inner value <typeparamref name="T4"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T5">
    /// The fifth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <param name="fourth">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4, T5}"/> with <paramref name="fourth"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4, T5> New<T1, T2, T3, T4, T5>(T4 fourth)
        =>
            new InnerEither<T1, T2, T3, T4, T5>(fourth);

    /// <summary>
    /// Creates a <see cref="IEither{T1, T2, T3, T4, T5}"/> with the inner value <typeparamref name="T5"/>.
    /// </summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <typeparam name="T5">
    /// The fifth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </typeparam>
    /// <param name="fifth">
    /// The parameter to pass in the type <see cref="IEither{T1, T2, T3, T4, T5}"/>.
    /// </param>
    /// <returns><see cref="IEither{T1, T2, T3, T4, T5}"/> with <paramref name="fifth"/>.</returns>
    [Pure]
    public static IEither<T1, T2, T3, T4, T5> New<T1, T2, T3, T4, T5>(T5 fifth)
        =>
            new InnerEither<T1, T2, T3, T4, T5>(fifth);

#endif
}
