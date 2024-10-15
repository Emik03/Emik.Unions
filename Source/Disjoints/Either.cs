// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

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
        where T1 : notnull
        where T2 : notnull
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
        where T1 : notnull
        where T2 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        =>
            new InnerEither<T1, T2, T3, T4>(fourth);

#if !NETFRAMEWORK || NET40_OR_GREATER
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
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
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
        =>
            new InnerEither<T1, T2, T3, T4, T5>(fifth);

#endif
}
