// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent RedundantCast RedundantLinebreak UnusedMemberInSuper.Global
// ReSharper disable InconsistentNaming
// <copyright file="EitherExtensions.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Disjoints;
#pragma warning disable SA1001, SA1508
/// <summary>A static class that provides functionality for disjoint union types.</summary>
public static class EitherExtensions
{
    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1">The truthy value.</param>
    /// <param name="n2">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2>(
        this IEither<T1, T2> that,
        [NotNullWhen(true)] out T1? n1,
        [NotNullWhen(false)] out T2? n2
    )
    {
        if (that.Index is >= 0 and <= 1)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2.");

        if (that.Index is not 0)
        {
            n1 = default;

            n2 = that.Second ?? throw Unreachable;

            return false;
        }

        n1 = that.First ?? throw Unreachable;

        n2 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2">The truthy value.</param>
    /// <param name="n1">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2>(
        this IEither<T1, T2> that,
        [NotNullWhen(true)] out T2? n2,
        [NotNullWhen(false)] out T1? n1
    )
    {
        if (that.Index is >= 0 and <= 1)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2.");

        if (that.Index is not 1)
        {
            n2 = default;

            n1 = that.First ?? throw Unreachable;

            return false;
        }

        n2 = that.Second ?? throw Unreachable;

        n1 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2>(
        this IEither<T1, T2> that,
        [NotNullWhen(true)] out T1? n1
    )
    {
        if (that.Index is >= 0 and <= 1)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2.");

        if (that.Index is not 0)
        {
            n1 = default;

            return false;
        }

        n1 = that.First ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2>(
        this IEither<T1, T2> that,
        [NotNullWhen(true)] out T2? n2
    )
    {
        if (that.Index is >= 0 and <= 1)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2.");

        if (that.Index is not 1)
        {
            n2 = default;

            return false;
        }

        n2 = that.Second ?? throw Unreachable;

        return true;
    }

    /// <summary>Runs the callback based on the value of the disjoint union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="on1">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2}.First"/>.
    /// </param>
    /// <param name="on2">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2}.Second"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>Itself.</returns>
    public static IEither<T1, T2> Is<T1, T2>(
        this IEither<T1, T2> that,
        [InstantHandle] Action<T1>? on1 = null,
        [InstantHandle] Action<T2>? on2 = null)
    {
        switch (that.Index)
        {
            case 0:
                on1?.Invoke(that.First ?? throw Unreachable);
                return that;
            case 1:
                on2?.Invoke(that.Second ?? throw Unreachable);
                return that;
        }

        throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2.");
    }

    /// <summary>Runs the callback based on the value of the disjoint union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="TResult">The type for the <see langword="return"/> type of the callbacks.</typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="on1">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2}.First"/>.
    /// </param>
    /// <param name="on2">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2}.Second"/>.
    /// </param>
    /// <returns>
    /// The value returned from the callback that corresponded to the
    /// <see cref="IEither.Value"/> of <paramref name="that"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    [MustUseReturnValue]
    public static TResult Is<T1, T2, TResult>(
        this IEither<T1, T2> that,
        [InstantHandle] Converter<T1, TResult> on1,
        [InstantHandle] Converter<T2, TResult> on2) =>
       that.Index switch
       {
           0 => on1(that.First ?? throw Unreachable),
           1 => on2(that.Second ?? throw Unreachable),
           _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2."),
       };

    /// <summary>Performs an index operation on the disjoint union.</summary>
    /// <typeparam name="T1">The first generic parameter of <see cref="IEither{T1, T2}"/>.</typeparam>
    /// <typeparam name="T2">The second generic parameter of <see cref="IEither{T1, T2}"/>.</typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="index">The index to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the index of the disjoint union.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The value <paramref name="index"/> is out of range.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2>(
        this IEither<T1, T2> that,
        [ValueRange(0, 1)] int index)
        =>
            index switch
            {
                0 => new(that.Properties[0], that.First),
                1 => new(that.Properties[1], that.Second),
                _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2."),
            };

    /// <summary>Gets the <see cref="Type"/> of <see cref="IEither.Value"/>.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <returns>The <see cref="Type"/> of the <see cref="IEither.Value"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    [Pure]
    public static Type InnerType<T1, T2>(this IEither<T1, T2> that) =>
        that.Index switch
        {
            0 => (Type)typeof(T1),
            1 => (Type)typeof(T2),
            _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2."),
        };

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1">The truthy value.</param>
    /// <param name="n2n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out T1? n1,
        [NotNullWhen(false)] out IEither<T2, T3>? n2n3
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 0)
        {
            n1 = default;

            n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
                that.Third is { } third ? Either.New<T2, T3>(third) :
                throw Unreachable;

            return false;
        }

        n1 = that.First ?? throw Unreachable;

        n2n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2">The truthy value.</param>
    /// <param name="n1n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out T2? n2,
        [NotNullWhen(false)] out IEither<T1, T3>? n1n3
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 1)
        {
            n2 = default;

            n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
                that.Third is { } third ? Either.New<T1, T3>(third) :
                throw Unreachable;

            return false;
        }

        n2 = that.Second ?? throw Unreachable;

        n1n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2">The truthy value.</param>
    /// <param name="n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out IEither<T1, T2>? n1n2,
        [NotNullWhen(false)] out T3? n3
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 0 and not 1)
        {
            n1n2 = default;

            n3 = that.Third ?? throw Unreachable;

            return false;
        }

        n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
            that.Second is { } second ? Either.New<T1, T2>(second) :
            throw Unreachable;

        n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3">The truthy value.</param>
    /// <param name="n1n2">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out T3? n3,
        [NotNullWhen(false)] out IEither<T1, T2>? n1n2
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 2)
        {
            n3 = default;

            n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
                that.Second is { } second ? Either.New<T1, T2>(second) :
                throw Unreachable;

            return false;
        }

        n3 = that.Third ?? throw Unreachable;

        n1n2 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3">The truthy value.</param>
    /// <param name="n2">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out IEither<T1, T3>? n1n3,
        [NotNullWhen(false)] out T2? n2
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 0 and not 2)
        {
            n1n3 = default;

            n2 = that.Second ?? throw Unreachable;

            return false;
        }

        n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
            that.Third is { } third ? Either.New<T1, T3>(third) :
            throw Unreachable;

        n2 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3">The truthy value.</param>
    /// <param name="n1">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out IEither<T2, T3>? n2n3,
        [NotNullWhen(false)] out T1? n1
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 1 and not 2)
        {
            n2n3 = default;

            n1 = that.First ?? throw Unreachable;

            return false;
        }

        n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
            that.Third is { } third ? Either.New<T2, T3>(third) :
            throw Unreachable;

        n1 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out T1? n1
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 0)
        {
            n1 = default;

            return false;
        }

        n1 = that.First ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out T2? n2
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 1)
        {
            n2 = default;

            return false;
        }

        n2 = that.Second ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out IEither<T1, T2>? n1n2
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 0 and not 1)
        {
            n1n2 = default;

            return false;
        }

        n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
            that.Second is { } second ? Either.New<T1, T2>(second) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out T3? n3
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 2)
        {
            n3 = default;

            return false;
        }

        n3 = that.Third ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out IEither<T1, T3>? n1n3
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 0 and not 2)
        {
            n1n3 = default;

            return false;
        }

        n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
            that.Third is { } third ? Either.New<T1, T3>(third) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [NotNullWhen(true)] out IEither<T2, T3>? n2n3
    )
    {
        if (that.Index is >= 0 and <= 2)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");

        if (that.Index is not 1 and not 2)
        {
            n2n3 = default;

            return false;
        }

        n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
            that.Third is { } third ? Either.New<T2, T3>(third) :
            throw Unreachable;

        return true;
    }

    /// <summary>Runs the callback based on the value of the disjoint union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="on1">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3}.First"/>.
    /// </param>
    /// <param name="on2">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3}.Second"/>.
    /// </param>
    /// <param name="on3">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3}.Third"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>Itself.</returns>
    public static IEither<T1, T2, T3> Is<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [InstantHandle] Action<T1>? on1 = null,
        [InstantHandle] Action<T2>? on2 = null,
        [InstantHandle] Action<T3>? on3 = null)
    {
        switch (that.Index)
        {
            case 0:
                on1?.Invoke(that.First ?? throw Unreachable);
                return that;
            case 1:
                on2?.Invoke(that.Second ?? throw Unreachable);
                return that;
            case 2:
                on3?.Invoke(that.Third ?? throw Unreachable);
                return that;
        }

        throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3.");
    }

    /// <summary>Runs the callback based on the value of the disjoint union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="TResult">The type for the <see langword="return"/> type of the callbacks.</typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="on1">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3}.First"/>.
    /// </param>
    /// <param name="on2">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3}.Second"/>.
    /// </param>
    /// <param name="on3">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3}.Third"/>.
    /// </param>
    /// <returns>
    /// The value returned from the callback that corresponded to the
    /// <see cref="IEither.Value"/> of <paramref name="that"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    [MustUseReturnValue]
    public static TResult Is<T1, T2, T3, TResult>(
        this IEither<T1, T2, T3> that,
        [InstantHandle] Converter<T1, TResult> on1,
        [InstantHandle] Converter<T2, TResult> on2,
        [InstantHandle] Converter<T3, TResult> on3) =>
       that.Index switch
       {
           0 => on1(that.First ?? throw Unreachable),
           1 => on2(that.Second ?? throw Unreachable),
           2 => on3(that.Third ?? throw Unreachable),
           _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3."),
       };

    /// <summary>Performs an index operation on the disjoint union.</summary>
    /// <typeparam name="T1">The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.</typeparam>
    /// <typeparam name="T2">The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.</typeparam>
    /// <typeparam name="T3">The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.</typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="index">The index to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the index of the disjoint union.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The value <paramref name="index"/> is out of range.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2, T3>(
        this IEither<T1, T2, T3> that,
        [ValueRange(0, 2)] int index)
        =>
            index switch
            {
                0 => new(that.Properties[0], that.First),
                1 => new(that.Properties[1], that.Second),
                2 => new(that.Properties[2], that.Third),
                _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3."),
            };

    /// <summary>Gets the <see cref="Type"/> of <see cref="IEither.Value"/>.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IEither{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <returns>The <see cref="Type"/> of the <see cref="IEither.Value"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    [Pure]
    public static Type InnerType<T1, T2, T3>(this IEither<T1, T2, T3> that) =>
        that.Index switch
        {
            0 => (Type)typeof(T1),
            1 => (Type)typeof(T2),
            2 => (Type)typeof(T3),
            _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3."),
        };

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1">The truthy value.</param>
    /// <param name="n2n3n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out T1? n1,
        [NotNullWhen(false)] out IEither<T2, T3, T4>? n2n3n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0)
        {
            n1 = default;

            n2n3n4 = that.Second is { } second ? Either.New<T2, T3, T4>(second) :
                that.Third is { } third ? Either.New<T2, T3, T4>(third) :
                that.Fourth is { } fourth ? Either.New<T2, T3, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n1 = that.First ?? throw Unreachable;

        n2n3n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2">The truthy value.</param>
    /// <param name="n1n3n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out T2? n2,
        [NotNullWhen(false)] out IEither<T1, T3, T4>? n1n3n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 1)
        {
            n2 = default;

            n1n3n4 = that.First is { } first ? Either.New<T1, T3, T4>(first) :
                that.Third is { } third ? Either.New<T1, T3, T4>(third) :
                that.Fourth is { } fourth ? Either.New<T1, T3, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n2 = that.Second ?? throw Unreachable;

        n1n3n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2">The truthy value.</param>
    /// <param name="n3n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T2>? n1n2,
        [NotNullWhen(false)] out IEither<T3, T4>? n3n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 1)
        {
            n1n2 = default;

            n3n4 = that.Third is { } third ? Either.New<T3, T4>(third) :
                that.Fourth is { } fourth ? Either.New<T3, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
            that.Second is { } second ? Either.New<T1, T2>(second) :
            throw Unreachable;

        n3n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3">The truthy value.</param>
    /// <param name="n1n2n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out T3? n3,
        [NotNullWhen(false)] out IEither<T1, T2, T4>? n1n2n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 2)
        {
            n3 = default;

            n1n2n4 = that.First is { } first ? Either.New<T1, T2, T4>(first) :
                that.Second is { } second ? Either.New<T1, T2, T4>(second) :
                that.Fourth is { } fourth ? Either.New<T1, T2, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n3 = that.Third ?? throw Unreachable;

        n1n2n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3">The truthy value.</param>
    /// <param name="n2n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T3>? n1n3,
        [NotNullWhen(false)] out IEither<T2, T4>? n2n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 2)
        {
            n1n3 = default;

            n2n4 = that.Second is { } second ? Either.New<T2, T4>(second) :
                that.Fourth is { } fourth ? Either.New<T2, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
            that.Third is { } third ? Either.New<T1, T3>(third) :
            throw Unreachable;

        n2n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3">The truthy value.</param>
    /// <param name="n1n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T2, T3>? n2n3,
        [NotNullWhen(false)] out IEither<T1, T4>? n1n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 1 and not 2)
        {
            n2n3 = default;

            n1n4 = that.First is { } first ? Either.New<T1, T4>(first) :
                that.Fourth is { } fourth ? Either.New<T1, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
            that.Third is { } third ? Either.New<T2, T3>(third) :
            throw Unreachable;

        n1n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n3">The truthy value.</param>
    /// <param name="n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T2, T3>? n1n2n3,
        [NotNullWhen(false)] out T4? n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 1 and not 2)
        {
            n1n2n3 = default;

            n4 = that.Fourth ?? throw Unreachable;

            return false;
        }

        n1n2n3 = that.First is { } first ? Either.New<T1, T2, T3>(first) :
            that.Second is { } second ? Either.New<T1, T2, T3>(second) :
            that.Third is { } third ? Either.New<T1, T2, T3>(third) :
            throw Unreachable;

        n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n4">The truthy value.</param>
    /// <param name="n1n2n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out T4? n4,
        [NotNullWhen(false)] out IEither<T1, T2, T3>? n1n2n3
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 3)
        {
            n4 = default;

            n1n2n3 = that.First is { } first ? Either.New<T1, T2, T3>(first) :
                that.Second is { } second ? Either.New<T1, T2, T3>(second) :
                that.Third is { } third ? Either.New<T1, T2, T3>(third) :
                throw Unreachable;

            return false;
        }

        n4 = that.Fourth ?? throw Unreachable;

        n1n2n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n4">The truthy value.</param>
    /// <param name="n2n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T4>? n1n4,
        [NotNullWhen(false)] out IEither<T2, T3>? n2n3
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 3)
        {
            n1n4 = default;

            n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
                that.Third is { } third ? Either.New<T2, T3>(third) :
                throw Unreachable;

            return false;
        }

        n1n4 = that.First is { } first ? Either.New<T1, T4>(first) :
            that.Fourth is { } fourth ? Either.New<T1, T4>(fourth) :
            throw Unreachable;

        n2n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n4">The truthy value.</param>
    /// <param name="n1n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T2, T4>? n2n4,
        [NotNullWhen(false)] out IEither<T1, T3>? n1n3
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 1 and not 3)
        {
            n2n4 = default;

            n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
                that.Third is { } third ? Either.New<T1, T3>(third) :
                throw Unreachable;

            return false;
        }

        n2n4 = that.Second is { } second ? Either.New<T2, T4>(second) :
            that.Fourth is { } fourth ? Either.New<T2, T4>(fourth) :
            throw Unreachable;

        n1n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n4">The truthy value.</param>
    /// <param name="n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T2, T4>? n1n2n4,
        [NotNullWhen(false)] out T3? n3
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 1 and not 3)
        {
            n1n2n4 = default;

            n3 = that.Third ?? throw Unreachable;

            return false;
        }

        n1n2n4 = that.First is { } first ? Either.New<T1, T2, T4>(first) :
            that.Second is { } second ? Either.New<T1, T2, T4>(second) :
            that.Fourth is { } fourth ? Either.New<T1, T2, T4>(fourth) :
            throw Unreachable;

        n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3n4">The truthy value.</param>
    /// <param name="n1n2">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T3, T4>? n3n4,
        [NotNullWhen(false)] out IEither<T1, T2>? n1n2
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 2 and not 3)
        {
            n3n4 = default;

            n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
                that.Second is { } second ? Either.New<T1, T2>(second) :
                throw Unreachable;

            return false;
        }

        n3n4 = that.Third is { } third ? Either.New<T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T3, T4>(fourth) :
            throw Unreachable;

        n1n2 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3n4">The truthy value.</param>
    /// <param name="n2">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T3, T4>? n1n3n4,
        [NotNullWhen(false)] out T2? n2
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 2 and not 3)
        {
            n1n3n4 = default;

            n2 = that.Second ?? throw Unreachable;

            return false;
        }

        n1n3n4 = that.First is { } first ? Either.New<T1, T3, T4>(first) :
            that.Third is { } third ? Either.New<T1, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T1, T3, T4>(fourth) :
            throw Unreachable;

        n2 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3n4">The truthy value.</param>
    /// <param name="n1">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T2, T3, T4>? n2n3n4,
        [NotNullWhen(false)] out T1? n1
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 1 and not 2 and not 3)
        {
            n2n3n4 = default;

            n1 = that.First ?? throw Unreachable;

            return false;
        }

        n2n3n4 = that.Second is { } second ? Either.New<T2, T3, T4>(second) :
            that.Third is { } third ? Either.New<T2, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T2, T3, T4>(fourth) :
            throw Unreachable;

        n1 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out T1? n1
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0)
        {
            n1 = default;

            return false;
        }

        n1 = that.First ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out T2? n2
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 1)
        {
            n2 = default;

            return false;
        }

        n2 = that.Second ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T2>? n1n2
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 1)
        {
            n1n2 = default;

            return false;
        }

        n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
            that.Second is { } second ? Either.New<T1, T2>(second) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out T3? n3
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 2)
        {
            n3 = default;

            return false;
        }

        n3 = that.Third ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T3>? n1n3
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 2)
        {
            n1n3 = default;

            return false;
        }

        n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
            that.Third is { } third ? Either.New<T1, T3>(third) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T2, T3>? n2n3
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 1 and not 2)
        {
            n2n3 = default;

            return false;
        }

        n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
            that.Third is { } third ? Either.New<T2, T3>(third) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T2, T3>? n1n2n3
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 1 and not 2)
        {
            n1n2n3 = default;

            return false;
        }

        n1n2n3 = that.First is { } first ? Either.New<T1, T2, T3>(first) :
            that.Second is { } second ? Either.New<T1, T2, T3>(second) :
            that.Third is { } third ? Either.New<T1, T2, T3>(third) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out T4? n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 3)
        {
            n4 = default;

            return false;
        }

        n4 = that.Fourth ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T4>? n1n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 3)
        {
            n1n4 = default;

            return false;
        }

        n1n4 = that.First is { } first ? Either.New<T1, T4>(first) :
            that.Fourth is { } fourth ? Either.New<T1, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T2, T4>? n2n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 1 and not 3)
        {
            n2n4 = default;

            return false;
        }

        n2n4 = that.Second is { } second ? Either.New<T2, T4>(second) :
            that.Fourth is { } fourth ? Either.New<T2, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T2, T4>? n1n2n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 1 and not 3)
        {
            n1n2n4 = default;

            return false;
        }

        n1n2n4 = that.First is { } first ? Either.New<T1, T2, T4>(first) :
            that.Second is { } second ? Either.New<T1, T2, T4>(second) :
            that.Fourth is { } fourth ? Either.New<T1, T2, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T3, T4>? n3n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 2 and not 3)
        {
            n3n4 = default;

            return false;
        }

        n3n4 = that.Third is { } third ? Either.New<T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T3, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T1, T3, T4>? n1n3n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 0 and not 2 and not 3)
        {
            n1n3n4 = default;

            return false;
        }

        n1n3n4 = that.First is { } first ? Either.New<T1, T3, T4>(first) :
            that.Third is { } third ? Either.New<T1, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T1, T3, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [NotNullWhen(true)] out IEither<T2, T3, T4>? n2n3n4
    )
    {
        if (that.Index is >= 0 and <= 3)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");

        if (that.Index is not 1 and not 2 and not 3)
        {
            n2n3n4 = default;

            return false;
        }

        n2n3n4 = that.Second is { } second ? Either.New<T2, T3, T4>(second) :
            that.Third is { } third ? Either.New<T2, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T2, T3, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Runs the callback based on the value of the disjoint union.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="on1">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4}.First"/>.
    /// </param>
    /// <param name="on2">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4}.Second"/>.
    /// </param>
    /// <param name="on3">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4}.Third"/>.
    /// </param>
    /// <param name="on4">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4}.Fourth"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>Itself.</returns>
    public static IEither<T1, T2, T3, T4> Is<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [InstantHandle] Action<T1>? on1 = null,
        [InstantHandle] Action<T2>? on2 = null,
        [InstantHandle] Action<T3>? on3 = null,
        [InstantHandle] Action<T4>? on4 = null)
    {
        switch (that.Index)
        {
            case 0:
                on1?.Invoke(that.First ?? throw Unreachable);
                return that;
            case 1:
                on2?.Invoke(that.Second ?? throw Unreachable);
                return that;
            case 2:
                on3?.Invoke(that.Third ?? throw Unreachable);
                return that;
            case 3:
                on4?.Invoke(that.Fourth ?? throw Unreachable);
                return that;
        }

        throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4.");
    }

    /// <summary>Runs the callback based on the value of the disjoint union.</summary>
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
    /// <typeparam name="TResult">The type for the <see langword="return"/> type of the callbacks.</typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="on1">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4}.First"/>.
    /// </param>
    /// <param name="on2">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4}.Second"/>.
    /// </param>
    /// <param name="on3">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4}.Third"/>.
    /// </param>
    /// <param name="on4">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4}.Fourth"/>.
    /// </param>
    /// <returns>
    /// The value returned from the callback that corresponded to the
    /// <see cref="IEither.Value"/> of <paramref name="that"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    [MustUseReturnValue]
    public static TResult Is<T1, T2, T3, T4, TResult>(
        this IEither<T1, T2, T3, T4> that,
        [InstantHandle] Converter<T1, TResult> on1,
        [InstantHandle] Converter<T2, TResult> on2,
        [InstantHandle] Converter<T3, TResult> on3,
        [InstantHandle] Converter<T4, TResult> on4) =>
       that.Index switch
       {
           0 => on1(that.First ?? throw Unreachable),
           1 => on2(that.Second ?? throw Unreachable),
           2 => on3(that.Third ?? throw Unreachable),
           3 => on4(that.Fourth ?? throw Unreachable),
           _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4."),
       };

    /// <summary>Performs an index operation on the disjoint union.</summary>
    /// <typeparam name="T1">The first generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.</typeparam>
    /// <typeparam name="T2">The second generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.</typeparam>
    /// <typeparam name="T3">The third generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.</typeparam>
    /// <typeparam name="T4">The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4}"/>.</typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="index">The index to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the index of the disjoint union.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The value <paramref name="index"/> is out of range.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2, T3, T4>(
        this IEither<T1, T2, T3, T4> that,
        [ValueRange(0, 3)] int index)
        =>
            index switch
            {
                0 => new(that.Properties[0], that.First),
                1 => new(that.Properties[1], that.Second),
                2 => new(that.Properties[2], that.Third),
                3 => new(that.Properties[3], that.Fourth),
                _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4."),
            };

    /// <summary>Gets the <see cref="Type"/> of <see cref="IEither.Value"/>.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <returns>The <see cref="Type"/> of the <see cref="IEither.Value"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    [Pure]
    public static Type InnerType<T1, T2, T3, T4>(this IEither<T1, T2, T3, T4> that) =>
        that.Index switch
        {
            0 => (Type)typeof(T1),
            1 => (Type)typeof(T2),
            2 => (Type)typeof(T3),
            3 => (Type)typeof(T4),
            _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4."),
        };

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1">The truthy value.</param>
    /// <param name="n2n3n4n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T1? n1,
        [NotNullWhen(false)] out IEither<T2, T3, T4, T5>? n2n3n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0)
        {
            n1 = default;

            n2n3n4n5 = that.Second is { } second ? Either.New<T2, T3, T4, T5>(second) :
                that.Third is { } third ? Either.New<T2, T3, T4, T5>(third) :
                that.Fourth is { } fourth ? Either.New<T2, T3, T4, T5>(fourth) :
                that.Fifth is { } fifth ? Either.New<T2, T3, T4, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n1 = that.First ?? throw Unreachable;

        n2n3n4n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2">The truthy value.</param>
    /// <param name="n1n3n4n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T2? n2,
        [NotNullWhen(false)] out IEither<T1, T3, T4, T5>? n1n3n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1)
        {
            n2 = default;

            n1n3n4n5 = that.First is { } first ? Either.New<T1, T3, T4, T5>(first) :
                that.Third is { } third ? Either.New<T1, T3, T4, T5>(third) :
                that.Fourth is { } fourth ? Either.New<T1, T3, T4, T5>(fourth) :
                that.Fifth is { } fifth ? Either.New<T1, T3, T4, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n2 = that.Second ?? throw Unreachable;

        n1n3n4n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2">The truthy value.</param>
    /// <param name="n3n4n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2>? n1n2,
        [NotNullWhen(false)] out IEither<T3, T4, T5>? n3n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1)
        {
            n1n2 = default;

            n3n4n5 = that.Third is { } third ? Either.New<T3, T4, T5>(third) :
                that.Fourth is { } fourth ? Either.New<T3, T4, T5>(fourth) :
                that.Fifth is { } fifth ? Either.New<T3, T4, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
            that.Second is { } second ? Either.New<T1, T2>(second) :
            throw Unreachable;

        n3n4n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3">The truthy value.</param>
    /// <param name="n1n2n4n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T3? n3,
        [NotNullWhen(false)] out IEither<T1, T2, T4, T5>? n1n2n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 2)
        {
            n3 = default;

            n1n2n4n5 = that.First is { } first ? Either.New<T1, T2, T4, T5>(first) :
                that.Second is { } second ? Either.New<T1, T2, T4, T5>(second) :
                that.Fourth is { } fourth ? Either.New<T1, T2, T4, T5>(fourth) :
                that.Fifth is { } fifth ? Either.New<T1, T2, T4, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n3 = that.Third ?? throw Unreachable;

        n1n2n4n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3">The truthy value.</param>
    /// <param name="n2n4n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T3>? n1n3,
        [NotNullWhen(false)] out IEither<T2, T4, T5>? n2n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 2)
        {
            n1n3 = default;

            n2n4n5 = that.Second is { } second ? Either.New<T2, T4, T5>(second) :
                that.Fourth is { } fourth ? Either.New<T2, T4, T5>(fourth) :
                that.Fifth is { } fifth ? Either.New<T2, T4, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
            that.Third is { } third ? Either.New<T1, T3>(third) :
            throw Unreachable;

        n2n4n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3">The truthy value.</param>
    /// <param name="n1n4n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T3>? n2n3,
        [NotNullWhen(false)] out IEither<T1, T4, T5>? n1n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 2)
        {
            n2n3 = default;

            n1n4n5 = that.First is { } first ? Either.New<T1, T4, T5>(first) :
                that.Fourth is { } fourth ? Either.New<T1, T4, T5>(fourth) :
                that.Fifth is { } fifth ? Either.New<T1, T4, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
            that.Third is { } third ? Either.New<T2, T3>(third) :
            throw Unreachable;

        n1n4n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n3">The truthy value.</param>
    /// <param name="n4n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T3>? n1n2n3,
        [NotNullWhen(false)] out IEither<T4, T5>? n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 2)
        {
            n1n2n3 = default;

            n4n5 = that.Fourth is { } fourth ? Either.New<T4, T5>(fourth) :
                that.Fifth is { } fifth ? Either.New<T4, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n1n2n3 = that.First is { } first ? Either.New<T1, T2, T3>(first) :
            that.Second is { } second ? Either.New<T1, T2, T3>(second) :
            that.Third is { } third ? Either.New<T1, T2, T3>(third) :
            throw Unreachable;

        n4n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n4">The truthy value.</param>
    /// <param name="n1n2n3n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T4? n4,
        [NotNullWhen(false)] out IEither<T1, T2, T3, T5>? n1n2n3n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 3)
        {
            n4 = default;

            n1n2n3n5 = that.First is { } first ? Either.New<T1, T2, T3, T5>(first) :
                that.Second is { } second ? Either.New<T1, T2, T3, T5>(second) :
                that.Third is { } third ? Either.New<T1, T2, T3, T5>(third) :
                that.Fifth is { } fifth ? Either.New<T1, T2, T3, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n4 = that.Fourth ?? throw Unreachable;

        n1n2n3n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n4">The truthy value.</param>
    /// <param name="n2n3n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T4>? n1n4,
        [NotNullWhen(false)] out IEither<T2, T3, T5>? n2n3n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 3)
        {
            n1n4 = default;

            n2n3n5 = that.Second is { } second ? Either.New<T2, T3, T5>(second) :
                that.Third is { } third ? Either.New<T2, T3, T5>(third) :
                that.Fifth is { } fifth ? Either.New<T2, T3, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n1n4 = that.First is { } first ? Either.New<T1, T4>(first) :
            that.Fourth is { } fourth ? Either.New<T1, T4>(fourth) :
            throw Unreachable;

        n2n3n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n4">The truthy value.</param>
    /// <param name="n1n3n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T4>? n2n4,
        [NotNullWhen(false)] out IEither<T1, T3, T5>? n1n3n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 3)
        {
            n2n4 = default;

            n1n3n5 = that.First is { } first ? Either.New<T1, T3, T5>(first) :
                that.Third is { } third ? Either.New<T1, T3, T5>(third) :
                that.Fifth is { } fifth ? Either.New<T1, T3, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n2n4 = that.Second is { } second ? Either.New<T2, T4>(second) :
            that.Fourth is { } fourth ? Either.New<T2, T4>(fourth) :
            throw Unreachable;

        n1n3n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n4">The truthy value.</param>
    /// <param name="n3n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T4>? n1n2n4,
        [NotNullWhen(false)] out IEither<T3, T5>? n3n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 3)
        {
            n1n2n4 = default;

            n3n5 = that.Third is { } third ? Either.New<T3, T5>(third) :
                that.Fifth is { } fifth ? Either.New<T3, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n1n2n4 = that.First is { } first ? Either.New<T1, T2, T4>(first) :
            that.Second is { } second ? Either.New<T1, T2, T4>(second) :
            that.Fourth is { } fourth ? Either.New<T1, T2, T4>(fourth) :
            throw Unreachable;

        n3n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3n4">The truthy value.</param>
    /// <param name="n1n2n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T3, T4>? n3n4,
        [NotNullWhen(false)] out IEither<T1, T2, T5>? n1n2n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 2 and not 3)
        {
            n3n4 = default;

            n1n2n5 = that.First is { } first ? Either.New<T1, T2, T5>(first) :
                that.Second is { } second ? Either.New<T1, T2, T5>(second) :
                that.Fifth is { } fifth ? Either.New<T1, T2, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n3n4 = that.Third is { } third ? Either.New<T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T3, T4>(fourth) :
            throw Unreachable;

        n1n2n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3n4">The truthy value.</param>
    /// <param name="n2n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T3, T4>? n1n3n4,
        [NotNullWhen(false)] out IEither<T2, T5>? n2n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 2 and not 3)
        {
            n1n3n4 = default;

            n2n5 = that.Second is { } second ? Either.New<T2, T5>(second) :
                that.Fifth is { } fifth ? Either.New<T2, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n1n3n4 = that.First is { } first ? Either.New<T1, T3, T4>(first) :
            that.Third is { } third ? Either.New<T1, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T1, T3, T4>(fourth) :
            throw Unreachable;

        n2n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3n4">The truthy value.</param>
    /// <param name="n1n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T3, T4>? n2n3n4,
        [NotNullWhen(false)] out IEither<T1, T5>? n1n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 2 and not 3)
        {
            n2n3n4 = default;

            n1n5 = that.First is { } first ? Either.New<T1, T5>(first) :
                that.Fifth is { } fifth ? Either.New<T1, T5>(fifth) :
                throw Unreachable;

            return false;
        }

        n2n3n4 = that.Second is { } second ? Either.New<T2, T3, T4>(second) :
            that.Third is { } third ? Either.New<T2, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T2, T3, T4>(fourth) :
            throw Unreachable;

        n1n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n3n4">The truthy value.</param>
    /// <param name="n5">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T3, T4>? n1n2n3n4,
        [NotNullWhen(false)] out T5? n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 2 and not 3)
        {
            n1n2n3n4 = default;

            n5 = that.Fifth ?? throw Unreachable;

            return false;
        }

        n1n2n3n4 = that.First is { } first ? Either.New<T1, T2, T3, T4>(first) :
            that.Second is { } second ? Either.New<T1, T2, T3, T4>(second) :
            that.Third is { } third ? Either.New<T1, T2, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T1, T2, T3, T4>(fourth) :
            throw Unreachable;

        n5 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n5">The truthy value.</param>
    /// <param name="n1n2n3n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T5? n5,
        [NotNullWhen(false)] out IEither<T1, T2, T3, T4>? n1n2n3n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 4)
        {
            n5 = default;

            n1n2n3n4 = that.First is { } first ? Either.New<T1, T2, T3, T4>(first) :
                that.Second is { } second ? Either.New<T1, T2, T3, T4>(second) :
                that.Third is { } third ? Either.New<T1, T2, T3, T4>(third) :
                that.Fourth is { } fourth ? Either.New<T1, T2, T3, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n5 = that.Fifth ?? throw Unreachable;

        n1n2n3n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n5">The truthy value.</param>
    /// <param name="n2n3n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T5>? n1n5,
        [NotNullWhen(false)] out IEither<T2, T3, T4>? n2n3n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 4)
        {
            n1n5 = default;

            n2n3n4 = that.Second is { } second ? Either.New<T2, T3, T4>(second) :
                that.Third is { } third ? Either.New<T2, T3, T4>(third) :
                that.Fourth is { } fourth ? Either.New<T2, T3, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n1n5 = that.First is { } first ? Either.New<T1, T5>(first) :
            that.Fifth is { } fifth ? Either.New<T1, T5>(fifth) :
            throw Unreachable;

        n2n3n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n5">The truthy value.</param>
    /// <param name="n1n3n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T5>? n2n5,
        [NotNullWhen(false)] out IEither<T1, T3, T4>? n1n3n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 4)
        {
            n2n5 = default;

            n1n3n4 = that.First is { } first ? Either.New<T1, T3, T4>(first) :
                that.Third is { } third ? Either.New<T1, T3, T4>(third) :
                that.Fourth is { } fourth ? Either.New<T1, T3, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n2n5 = that.Second is { } second ? Either.New<T2, T5>(second) :
            that.Fifth is { } fifth ? Either.New<T2, T5>(fifth) :
            throw Unreachable;

        n1n3n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n5">The truthy value.</param>
    /// <param name="n3n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T5>? n1n2n5,
        [NotNullWhen(false)] out IEither<T3, T4>? n3n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 4)
        {
            n1n2n5 = default;

            n3n4 = that.Third is { } third ? Either.New<T3, T4>(third) :
                that.Fourth is { } fourth ? Either.New<T3, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n1n2n5 = that.First is { } first ? Either.New<T1, T2, T5>(first) :
            that.Second is { } second ? Either.New<T1, T2, T5>(second) :
            that.Fifth is { } fifth ? Either.New<T1, T2, T5>(fifth) :
            throw Unreachable;

        n3n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3n5">The truthy value.</param>
    /// <param name="n1n2n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T3, T5>? n3n5,
        [NotNullWhen(false)] out IEither<T1, T2, T4>? n1n2n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 2 and not 4)
        {
            n3n5 = default;

            n1n2n4 = that.First is { } first ? Either.New<T1, T2, T4>(first) :
                that.Second is { } second ? Either.New<T1, T2, T4>(second) :
                that.Fourth is { } fourth ? Either.New<T1, T2, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n3n5 = that.Third is { } third ? Either.New<T3, T5>(third) :
            that.Fifth is { } fifth ? Either.New<T3, T5>(fifth) :
            throw Unreachable;

        n1n2n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3n5">The truthy value.</param>
    /// <param name="n2n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T3, T5>? n1n3n5,
        [NotNullWhen(false)] out IEither<T2, T4>? n2n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 2 and not 4)
        {
            n1n3n5 = default;

            n2n4 = that.Second is { } second ? Either.New<T2, T4>(second) :
                that.Fourth is { } fourth ? Either.New<T2, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n1n3n5 = that.First is { } first ? Either.New<T1, T3, T5>(first) :
            that.Third is { } third ? Either.New<T1, T3, T5>(third) :
            that.Fifth is { } fifth ? Either.New<T1, T3, T5>(fifth) :
            throw Unreachable;

        n2n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3n5">The truthy value.</param>
    /// <param name="n1n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T3, T5>? n2n3n5,
        [NotNullWhen(false)] out IEither<T1, T4>? n1n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 2 and not 4)
        {
            n2n3n5 = default;

            n1n4 = that.First is { } first ? Either.New<T1, T4>(first) :
                that.Fourth is { } fourth ? Either.New<T1, T4>(fourth) :
                throw Unreachable;

            return false;
        }

        n2n3n5 = that.Second is { } second ? Either.New<T2, T3, T5>(second) :
            that.Third is { } third ? Either.New<T2, T3, T5>(third) :
            that.Fifth is { } fifth ? Either.New<T2, T3, T5>(fifth) :
            throw Unreachable;

        n1n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n3n5">The truthy value.</param>
    /// <param name="n4">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T3, T5>? n1n2n3n5,
        [NotNullWhen(false)] out T4? n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 2 and not 4)
        {
            n1n2n3n5 = default;

            n4 = that.Fourth ?? throw Unreachable;

            return false;
        }

        n1n2n3n5 = that.First is { } first ? Either.New<T1, T2, T3, T5>(first) :
            that.Second is { } second ? Either.New<T1, T2, T3, T5>(second) :
            that.Third is { } third ? Either.New<T1, T2, T3, T5>(third) :
            that.Fifth is { } fifth ? Either.New<T1, T2, T3, T5>(fifth) :
            throw Unreachable;

        n4 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n4n5">The truthy value.</param>
    /// <param name="n1n2n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T4, T5>? n4n5,
        [NotNullWhen(false)] out IEither<T1, T2, T3>? n1n2n3
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 3 and not 4)
        {
            n4n5 = default;

            n1n2n3 = that.First is { } first ? Either.New<T1, T2, T3>(first) :
                that.Second is { } second ? Either.New<T1, T2, T3>(second) :
                that.Third is { } third ? Either.New<T1, T2, T3>(third) :
                throw Unreachable;

            return false;
        }

        n4n5 = that.Fourth is { } fourth ? Either.New<T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T4, T5>(fifth) :
            throw Unreachable;

        n1n2n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n4n5">The truthy value.</param>
    /// <param name="n2n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T4, T5>? n1n4n5,
        [NotNullWhen(false)] out IEither<T2, T3>? n2n3
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 3 and not 4)
        {
            n1n4n5 = default;

            n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
                that.Third is { } third ? Either.New<T2, T3>(third) :
                throw Unreachable;

            return false;
        }

        n1n4n5 = that.First is { } first ? Either.New<T1, T4, T5>(first) :
            that.Fourth is { } fourth ? Either.New<T1, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T1, T4, T5>(fifth) :
            throw Unreachable;

        n2n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n4n5">The truthy value.</param>
    /// <param name="n1n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T4, T5>? n2n4n5,
        [NotNullWhen(false)] out IEither<T1, T3>? n1n3
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 3 and not 4)
        {
            n2n4n5 = default;

            n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
                that.Third is { } third ? Either.New<T1, T3>(third) :
                throw Unreachable;

            return false;
        }

        n2n4n5 = that.Second is { } second ? Either.New<T2, T4, T5>(second) :
            that.Fourth is { } fourth ? Either.New<T2, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T2, T4, T5>(fifth) :
            throw Unreachable;

        n1n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n4n5">The truthy value.</param>
    /// <param name="n3">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T4, T5>? n1n2n4n5,
        [NotNullWhen(false)] out T3? n3
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 3 and not 4)
        {
            n1n2n4n5 = default;

            n3 = that.Third ?? throw Unreachable;

            return false;
        }

        n1n2n4n5 = that.First is { } first ? Either.New<T1, T2, T4, T5>(first) :
            that.Second is { } second ? Either.New<T1, T2, T4, T5>(second) :
            that.Fourth is { } fourth ? Either.New<T1, T2, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T1, T2, T4, T5>(fifth) :
            throw Unreachable;

        n3 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3n4n5">The truthy value.</param>
    /// <param name="n1n2">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T3, T4, T5>? n3n4n5,
        [NotNullWhen(false)] out IEither<T1, T2>? n1n2
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 2 and not 3 and not 4)
        {
            n3n4n5 = default;

            n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
                that.Second is { } second ? Either.New<T1, T2>(second) :
                throw Unreachable;

            return false;
        }

        n3n4n5 = that.Third is { } third ? Either.New<T3, T4, T5>(third) :
            that.Fourth is { } fourth ? Either.New<T3, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T3, T4, T5>(fifth) :
            throw Unreachable;

        n1n2 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3n4n5">The truthy value.</param>
    /// <param name="n2">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T3, T4, T5>? n1n3n4n5,
        [NotNullWhen(false)] out T2? n2
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 2 and not 3 and not 4)
        {
            n1n3n4n5 = default;

            n2 = that.Second ?? throw Unreachable;

            return false;
        }

        n1n3n4n5 = that.First is { } first ? Either.New<T1, T3, T4, T5>(first) :
            that.Third is { } third ? Either.New<T1, T3, T4, T5>(third) :
            that.Fourth is { } fourth ? Either.New<T1, T3, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T1, T3, T4, T5>(fifth) :
            throw Unreachable;

        n2 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3n4n5">The truthy value.</param>
    /// <param name="n1">The falsy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T3, T4, T5>? n2n3n4n5,
        [NotNullWhen(false)] out T1? n1
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 2 and not 3 and not 4)
        {
            n2n3n4n5 = default;

            n1 = that.First ?? throw Unreachable;

            return false;
        }

        n2n3n4n5 = that.Second is { } second ? Either.New<T2, T3, T4, T5>(second) :
            that.Third is { } third ? Either.New<T2, T3, T4, T5>(third) :
            that.Fourth is { } fourth ? Either.New<T2, T3, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T2, T3, T4, T5>(fifth) :
            throw Unreachable;

        n1 = default;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T1? n1
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0)
        {
            n1 = default;

            return false;
        }

        n1 = that.First ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T2? n2
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1)
        {
            n2 = default;

            return false;
        }

        n2 = that.Second ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2>? n1n2
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1)
        {
            n1n2 = default;

            return false;
        }

        n1n2 = that.First is { } first ? Either.New<T1, T2>(first) :
            that.Second is { } second ? Either.New<T1, T2>(second) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T3? n3
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 2)
        {
            n3 = default;

            return false;
        }

        n3 = that.Third ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T3>? n1n3
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 2)
        {
            n1n3 = default;

            return false;
        }

        n1n3 = that.First is { } first ? Either.New<T1, T3>(first) :
            that.Third is { } third ? Either.New<T1, T3>(third) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T3>? n2n3
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 2)
        {
            n2n3 = default;

            return false;
        }

        n2n3 = that.Second is { } second ? Either.New<T2, T3>(second) :
            that.Third is { } third ? Either.New<T2, T3>(third) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n3">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T3>? n1n2n3
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 2)
        {
            n1n2n3 = default;

            return false;
        }

        n1n2n3 = that.First is { } first ? Either.New<T1, T2, T3>(first) :
            that.Second is { } second ? Either.New<T1, T2, T3>(second) :
            that.Third is { } third ? Either.New<T1, T2, T3>(third) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T4? n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 3)
        {
            n4 = default;

            return false;
        }

        n4 = that.Fourth ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T4>? n1n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 3)
        {
            n1n4 = default;

            return false;
        }

        n1n4 = that.First is { } first ? Either.New<T1, T4>(first) :
            that.Fourth is { } fourth ? Either.New<T1, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T4>? n2n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 3)
        {
            n2n4 = default;

            return false;
        }

        n2n4 = that.Second is { } second ? Either.New<T2, T4>(second) :
            that.Fourth is { } fourth ? Either.New<T2, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T4>? n1n2n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 3)
        {
            n1n2n4 = default;

            return false;
        }

        n1n2n4 = that.First is { } first ? Either.New<T1, T2, T4>(first) :
            that.Second is { } second ? Either.New<T1, T2, T4>(second) :
            that.Fourth is { } fourth ? Either.New<T1, T2, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T3, T4>? n3n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 2 and not 3)
        {
            n3n4 = default;

            return false;
        }

        n3n4 = that.Third is { } third ? Either.New<T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T3, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T3, T4>? n1n3n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 2 and not 3)
        {
            n1n3n4 = default;

            return false;
        }

        n1n3n4 = that.First is { } first ? Either.New<T1, T3, T4>(first) :
            that.Third is { } third ? Either.New<T1, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T1, T3, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T3, T4>? n2n3n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 2 and not 3)
        {
            n2n3n4 = default;

            return false;
        }

        n2n3n4 = that.Second is { } second ? Either.New<T2, T3, T4>(second) :
            that.Third is { } third ? Either.New<T2, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T2, T3, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n3n4">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T3, T4>? n1n2n3n4
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 2 and not 3)
        {
            n1n2n3n4 = default;

            return false;
        }

        n1n2n3n4 = that.First is { } first ? Either.New<T1, T2, T3, T4>(first) :
            that.Second is { } second ? Either.New<T1, T2, T3, T4>(second) :
            that.Third is { } third ? Either.New<T1, T2, T3, T4>(third) :
            that.Fourth is { } fourth ? Either.New<T1, T2, T3, T4>(fourth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out T5? n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 4)
        {
            n5 = default;

            return false;
        }

        n5 = that.Fifth ?? throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T5>? n1n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 4)
        {
            n1n5 = default;

            return false;
        }

        n1n5 = that.First is { } first ? Either.New<T1, T5>(first) :
            that.Fifth is { } fifth ? Either.New<T1, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T5>? n2n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 4)
        {
            n2n5 = default;

            return false;
        }

        n2n5 = that.Second is { } second ? Either.New<T2, T5>(second) :
            that.Fifth is { } fifth ? Either.New<T2, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T5>? n1n2n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 4)
        {
            n1n2n5 = default;

            return false;
        }

        n1n2n5 = that.First is { } first ? Either.New<T1, T2, T5>(first) :
            that.Second is { } second ? Either.New<T1, T2, T5>(second) :
            that.Fifth is { } fifth ? Either.New<T1, T2, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T3, T5>? n3n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 2 and not 4)
        {
            n3n5 = default;

            return false;
        }

        n3n5 = that.Third is { } third ? Either.New<T3, T5>(third) :
            that.Fifth is { } fifth ? Either.New<T3, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T3, T5>? n1n3n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 2 and not 4)
        {
            n1n3n5 = default;

            return false;
        }

        n1n3n5 = that.First is { } first ? Either.New<T1, T3, T5>(first) :
            that.Third is { } third ? Either.New<T1, T3, T5>(third) :
            that.Fifth is { } fifth ? Either.New<T1, T3, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T3, T5>? n2n3n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 2 and not 4)
        {
            n2n3n5 = default;

            return false;
        }

        n2n3n5 = that.Second is { } second ? Either.New<T2, T3, T5>(second) :
            that.Third is { } third ? Either.New<T2, T3, T5>(third) :
            that.Fifth is { } fifth ? Either.New<T2, T3, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n3n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T3, T5>? n1n2n3n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 2 and not 4)
        {
            n1n2n3n5 = default;

            return false;
        }

        n1n2n3n5 = that.First is { } first ? Either.New<T1, T2, T3, T5>(first) :
            that.Second is { } second ? Either.New<T1, T2, T3, T5>(second) :
            that.Third is { } third ? Either.New<T1, T2, T3, T5>(third) :
            that.Fifth is { } fifth ? Either.New<T1, T2, T3, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n4n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T4, T5>? n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 3 and not 4)
        {
            n4n5 = default;

            return false;
        }

        n4n5 = that.Fourth is { } fourth ? Either.New<T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T4, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n4n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T4, T5>? n1n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 3 and not 4)
        {
            n1n4n5 = default;

            return false;
        }

        n1n4n5 = that.First is { } first ? Either.New<T1, T4, T5>(first) :
            that.Fourth is { } fourth ? Either.New<T1, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T1, T4, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n4n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T4, T5>? n2n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 3 and not 4)
        {
            n2n4n5 = default;

            return false;
        }

        n2n4n5 = that.Second is { } second ? Either.New<T2, T4, T5>(second) :
            that.Fourth is { } fourth ? Either.New<T2, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T2, T4, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n2n4n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T2, T4, T5>? n1n2n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 1 and not 3 and not 4)
        {
            n1n2n4n5 = default;

            return false;
        }

        n1n2n4n5 = that.First is { } first ? Either.New<T1, T2, T4, T5>(first) :
            that.Second is { } second ? Either.New<T1, T2, T4, T5>(second) :
            that.Fourth is { } fourth ? Either.New<T1, T2, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T1, T2, T4, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n3n4n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T3, T4, T5>? n3n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 2 and not 3 and not 4)
        {
            n3n4n5 = default;

            return false;
        }

        n3n4n5 = that.Third is { } third ? Either.New<T3, T4, T5>(third) :
            that.Fourth is { } fourth ? Either.New<T3, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T3, T4, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n1n3n4n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T1, T3, T4, T5>? n1n3n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 0 and not 2 and not 3 and not 4)
        {
            n1n3n4n5 = default;

            return false;
        }

        n1n3n4n5 = that.First is { } first ? Either.New<T1, T3, T4, T5>(first) :
            that.Third is { } third ? Either.New<T1, T3, T4, T5>(third) :
            that.Fourth is { } fourth ? Either.New<T1, T3, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T1, T3, T4, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Determines whether the disjoint union is the type provided.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="n2n3n4n5">The truthy value.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="that"/> matches the pattern,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [NotNullWhen(true)] out IEither<T2, T3, T4, T5>? n2n3n4n5
    )
    {
        if (that.Index is >= 0 and <= 4)
            throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");

        if (that.Index is not 1 and not 2 and not 3 and not 4)
        {
            n2n3n4n5 = default;

            return false;
        }

        n2n3n4n5 = that.Second is { } second ? Either.New<T2, T3, T4, T5>(second) :
            that.Third is { } third ? Either.New<T2, T3, T4, T5>(third) :
            that.Fourth is { } fourth ? Either.New<T2, T3, T4, T5>(fourth) :
            that.Fifth is { } fifth ? Either.New<T2, T3, T4, T5>(fifth) :
            throw Unreachable;

        return true;
    }

    /// <summary>Runs the callback based on the value of the disjoint union.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="on1">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.First"/>.
    /// </param>
    /// <param name="on2">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.Second"/>.
    /// </param>
    /// <param name="on3">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.Third"/>.
    /// </param>
    /// <param name="on4">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.Fourth"/>.
    /// </param>
    /// <param name="on5">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.Fifth"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    /// <returns>Itself.</returns>
    public static IEither<T1, T2, T3, T4, T5> Is<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [InstantHandle] Action<T1>? on1 = null,
        [InstantHandle] Action<T2>? on2 = null,
        [InstantHandle] Action<T3>? on3 = null,
        [InstantHandle] Action<T4>? on4 = null,
        [InstantHandle] Action<T5>? on5 = null)
    {
        switch (that.Index)
        {
            case 0:
                on1?.Invoke(that.First ?? throw Unreachable);
                return that;
            case 1:
                on2?.Invoke(that.Second ?? throw Unreachable);
                return that;
            case 2:
                on3?.Invoke(that.Third ?? throw Unreachable);
                return that;
            case 3:
                on4?.Invoke(that.Fourth ?? throw Unreachable);
                return that;
            case 4:
                on5?.Invoke(that.Fifth ?? throw Unreachable);
                return that;
        }

        throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5.");
    }

    /// <summary>Runs the callback based on the value of the disjoint union.</summary>
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
    /// <typeparam name="TResult">The type for the <see langword="return"/> type of the callbacks.</typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="on1">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.First"/>.
    /// </param>
    /// <param name="on2">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.Second"/>.
    /// </param>
    /// <param name="on3">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.Third"/>.
    /// </param>
    /// <param name="on4">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.Fourth"/>.
    /// </param>
    /// <param name="on5">
    /// The callback for <paramref name="that"/> having <see cref="IEither{T1, T2, T3, T4, T5}.Fifth"/>.
    /// </param>
    /// <returns>
    /// The value returned from the callback that corresponded to the
    /// <see cref="IEither.Value"/> of <paramref name="that"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    [MustUseReturnValue]
    public static TResult Is<T1, T2, T3, T4, T5, TResult>(
        this IEither<T1, T2, T3, T4, T5> that,
        [InstantHandle] Converter<T1, TResult> on1,
        [InstantHandle] Converter<T2, TResult> on2,
        [InstantHandle] Converter<T3, TResult> on3,
        [InstantHandle] Converter<T4, TResult> on4,
        [InstantHandle] Converter<T5, TResult> on5) =>
       that.Index switch
       {
           0 => on1(that.First ?? throw Unreachable),
           1 => on2(that.Second ?? throw Unreachable),
           2 => on3(that.Third ?? throw Unreachable),
           3 => on4(that.Fourth ?? throw Unreachable),
           4 => on5(that.Fifth ?? throw Unreachable),
           _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5."),
       };

    /// <summary>Performs an index operation on the disjoint union.</summary>
    /// <typeparam name="T1">The first generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.</typeparam>
    /// <typeparam name="T2">The second generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.</typeparam>
    /// <typeparam name="T3">The third generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.</typeparam>
    /// <typeparam name="T4">The fourth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.</typeparam>
    /// <typeparam name="T5">The fifth generic parameter of <see cref="IEither{T1, T2, T3, T4, T5}"/>.</typeparam>
    /// <param name="that">The instance of the disjoint union.</param>
    /// <param name="index">The index to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the index of the disjoint union.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The value <paramref name="index"/> is out of range.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2, T3, T4, T5>(
        this IEither<T1, T2, T3, T4, T5> that,
        [ValueRange(0, 4)] int index)
        =>
            index switch
            {
                0 => new(that.Properties[0], that.First),
                1 => new(that.Properties[1], that.Second),
                2 => new(that.Properties[2], that.Third),
                3 => new(that.Properties[3], that.Fourth),
                4 => new(that.Properties[4], that.Fifth),
                _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5."),
            };

    /// <summary>Gets the <see cref="Type"/> of <see cref="IEither.Value"/>.</summary>
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
    /// <param name="that">The instance of the disjoint union.</param>
    /// <returns>The <see cref="Type"/> of the <see cref="IEither.Value"/>.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The value <paramref name="that"/> has an invalid <see cref="IEither.Index"/>.
    /// </exception>
    [Pure]
    public static Type InnerType<T1, T2, T3, T4, T5>(this IEither<T1, T2, T3, T4, T5> that) =>
        that.Index switch
        {
            0 => (Type)typeof(T1),
            1 => (Type)typeof(T2),
            2 => (Type)typeof(T3),
            3 => (Type)typeof(T4),
            4 => (Type)typeof(T5),
            _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {that.Index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-5."),
        };

}
