// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

namespace Emik.Unions.Disjoints;
#pragma warning disable RCS1036, SA1508
/// <summary>An interface for everything that disjoint union types share in common with.</summary>
public interface IEither : IProperties
{
    /// <summary>Gets the index where the value is contained.</summary>
    [Pure, ValueRange(-1, int.MaxValue)]
    int Index { get; }

    /// <summary>Gets the value.</summary>
    [Pure]
    object? Value { get; }
}

/// <summary>Defines an interface for disjoint union of size 2.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
public interface IEither<out T1, out T2> : IEither
{
    /// <summary>Gets the <typeparamref name="T1"/> first value of the disjoint union.</summary>
    [Pure]
    T1? First { get; }

    /// <summary>Gets the <typeparamref name="T2"/> second value of the disjoint union.</summary>
    [Pure]
    T2? Second { get; }

}

/// <summary>Defines an interface for disjoint union of size 3.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
public interface IEither<out T1, out T2, out T3> : IEither
{
    /// <summary>Gets the <typeparamref name="T1"/> first value of the disjoint union.</summary>
    [Pure]
    T1? First { get; }

    /// <summary>Gets the <typeparamref name="T2"/> second value of the disjoint union.</summary>
    [Pure]
    T2? Second { get; }

    /// <summary>Gets the <typeparamref name="T3"/> third value of the disjoint union.</summary>
    [Pure]
    T3? Third { get; }

}

/// <summary>Defines an interface for disjoint union of size 4.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
public interface IEither<out T1, out T2, out T3, out T4> : IEither
{
    /// <summary>Gets the <typeparamref name="T1"/> first value of the disjoint union.</summary>
    [Pure]
    T1? First { get; }

    /// <summary>Gets the <typeparamref name="T2"/> second value of the disjoint union.</summary>
    [Pure]
    T2? Second { get; }

    /// <summary>Gets the <typeparamref name="T3"/> third value of the disjoint union.</summary>
    [Pure]
    T3? Third { get; }

    /// <summary>Gets the <typeparamref name="T4"/> fourth value of the disjoint union.</summary>
    [Pure]
    T4? Fourth { get; }

}

#if !NET35
/// <summary>Defines an interface for disjoint union of size 5.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
/// <typeparam name="T5">The fifth type of the disjoint union.</typeparam>
public interface IEither<out T1, out T2, out T3, out T4, out T5> : IEither
{
    /// <summary>Gets the <typeparamref name="T1"/> first value of the disjoint union.</summary>
    [Pure]
    T1? First { get; }

    /// <summary>Gets the <typeparamref name="T2"/> second value of the disjoint union.</summary>
    [Pure]
    T2? Second { get; }

    /// <summary>Gets the <typeparamref name="T3"/> third value of the disjoint union.</summary>
    [Pure]
    T3? Third { get; }

    /// <summary>Gets the <typeparamref name="T4"/> fourth value of the disjoint union.</summary>
    [Pure]
    T4? Fourth { get; }

    /// <summary>Gets the <typeparamref name="T5"/> fifth value of the disjoint union.</summary>
    [Pure]
    T5? Fifth { get; }

}

#endif
