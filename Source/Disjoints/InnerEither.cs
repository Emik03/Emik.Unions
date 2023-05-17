// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

namespace Emik.Unions.Disjoints;
#pragma warning disable RCS1036
/// <summary>
/// Defines an internal disjoint union for storing 1 of 2 different values.
/// Instances of this type are exposed to the consumer as an interface.
/// </summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
sealed record InnerEither<T1, T2> :
#if NET7_0_OR_GREATER
    IEqualityOperators<InnerEither<T1, T2>, InnerEither<T1, T2>, bool>,
#endif
    IEither<T1, T2>
        where T1 : notnull
        where T2 : notnull
{
    static readonly PropertyInfo[] s_properties =
        typeof(InnerEither<T1, T2>)
           .GetProperties(BindingFlags.Instance | BindingFlags.Public);

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2}"/> class.</summary>
    /// <param name="first">
    /// The <typeparamref name="T1"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T1 first)
    {
        Index = 0;
        First = first;
    }

    /// <inheritdoc/>
    [Pure]
    public T1? First { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2}"/> class.</summary>
    /// <param name="second">
    /// The <typeparamref name="T2"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T2 second)
    {
        Index = 1;
        Second = second;
    }

    /// <inheritdoc/>
    [Pure]
    public T2? Second { get; }

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(0, 1)]
    public int Index { get; }

    /// <inheritdoc/>
    [Pure]
    public object? Value => this[Index].Value;

    /// <inheritdoc/>
    [Pure]
    public
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ToReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => $"{nameof(Either)}[{Index}] {{ {Value} }}";
}

/// <summary>
/// Defines an internal disjoint union for storing 1 of 3 different values.
/// Instances of this type are exposed to the consumer as an interface.
/// </summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
sealed record InnerEither<T1, T2, T3> :
#if NET7_0_OR_GREATER
    IEqualityOperators<InnerEither<T1, T2, T3>, InnerEither<T1, T2, T3>, bool>,
#endif
    IEither<T1, T2, T3>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
{
    static readonly PropertyInfo[] s_properties =
        typeof(InnerEither<T1, T2, T3>)
           .GetProperties(BindingFlags.Instance | BindingFlags.Public);

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3}"/> class.</summary>
    /// <param name="first">
    /// The <typeparamref name="T1"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T1 first)
    {
        Index = 0;
        First = first;
    }

    /// <inheritdoc/>
    [Pure]
    public T1? First { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3}"/> class.</summary>
    /// <param name="second">
    /// The <typeparamref name="T2"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T2 second)
    {
        Index = 1;
        Second = second;
    }

    /// <inheritdoc/>
    [Pure]
    public T2? Second { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3}"/> class.</summary>
    /// <param name="third">
    /// The <typeparamref name="T3"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T3 third)
    {
        Index = 2;
        Third = third;
    }

    /// <inheritdoc/>
    [Pure]
    public T3? Third { get; }

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(0, 2)]
    public int Index { get; }

    /// <inheritdoc/>
    [Pure]
    public object? Value => this[Index].Value;

    /// <inheritdoc/>
    [Pure]
    public
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ToReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => $"{nameof(Either)}[{Index}] {{ {Value} }}";
}

/// <summary>
/// Defines an internal disjoint union for storing 1 of 4 different values.
/// Instances of this type are exposed to the consumer as an interface.
/// </summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
sealed record InnerEither<T1, T2, T3, T4> :
#if NET7_0_OR_GREATER
    IEqualityOperators<InnerEither<T1, T2, T3, T4>, InnerEither<T1, T2, T3, T4>, bool>,
#endif
    IEither<T1, T2, T3, T4>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
{
    static readonly PropertyInfo[] s_properties =
        typeof(InnerEither<T1, T2, T3, T4>)
           .GetProperties(BindingFlags.Instance | BindingFlags.Public);

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4}"/> class.</summary>
    /// <param name="first">
    /// The <typeparamref name="T1"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T1 first)
    {
        Index = 0;
        First = first;
    }

    /// <inheritdoc/>
    [Pure]
    public T1? First { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4}"/> class.</summary>
    /// <param name="second">
    /// The <typeparamref name="T2"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T2 second)
    {
        Index = 1;
        Second = second;
    }

    /// <inheritdoc/>
    [Pure]
    public T2? Second { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4}"/> class.</summary>
    /// <param name="third">
    /// The <typeparamref name="T3"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T3 third)
    {
        Index = 2;
        Third = third;
    }

    /// <inheritdoc/>
    [Pure]
    public T3? Third { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4}"/> class.</summary>
    /// <param name="fourth">
    /// The <typeparamref name="T4"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T4 fourth)
    {
        Index = 3;
        Fourth = fourth;
    }

    /// <inheritdoc/>
    [Pure]
    public T4? Fourth { get; }

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(0, 3)]
    public int Index { get; }

    /// <inheritdoc/>
    [Pure]
    public object? Value => this[Index].Value;

    /// <inheritdoc/>
    [Pure]
    public
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ToReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => $"{nameof(Either)}[{Index}] {{ {Value} }}";
}

#if !NETFRAMEWORK || NET40_OR_GREATER
/// <summary>
/// Defines an internal disjoint union for storing 1 of 5 different values.
/// Instances of this type are exposed to the consumer as an interface.
/// </summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
/// <typeparam name="T5">The fifth type of the disjoint union.</typeparam>
sealed record InnerEither<T1, T2, T3, T4, T5> :
#if NET7_0_OR_GREATER
    IEqualityOperators<InnerEither<T1, T2, T3, T4, T5>, InnerEither<T1, T2, T3, T4, T5>, bool>,
#endif
    IEither<T1, T2, T3, T4, T5>
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull
        where T5 : notnull
{
    static readonly PropertyInfo[] s_properties =
        typeof(InnerEither<T1, T2, T3, T4, T5>)
           .GetProperties(BindingFlags.Instance | BindingFlags.Public);

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4, T5}"/> class.</summary>
    /// <param name="first">
    /// The <typeparamref name="T1"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T1 first)
    {
        Index = 0;
        First = first;
    }

    /// <inheritdoc/>
    [Pure]
    public T1? First { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4, T5}"/> class.</summary>
    /// <param name="second">
    /// The <typeparamref name="T2"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T2 second)
    {
        Index = 1;
        Second = second;
    }

    /// <inheritdoc/>
    [Pure]
    public T2? Second { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4, T5}"/> class.</summary>
    /// <param name="third">
    /// The <typeparamref name="T3"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T3 third)
    {
        Index = 2;
        Third = third;
    }

    /// <inheritdoc/>
    [Pure]
    public T3? Third { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4, T5}"/> class.</summary>
    /// <param name="fourth">
    /// The <typeparamref name="T4"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T4 fourth)
    {
        Index = 3;
        Fourth = fourth;
    }

    /// <inheritdoc/>
    [Pure]
    public T4? Fourth { get; }

    /// <summary>Initializes a new instance of the <see cref="InnerEither{T1, T2, T3, T4, T5}"/> class.</summary>
    /// <param name="fifth">
    /// The <typeparamref name="T5"/> value to assign to the disjoint union.
    /// </param>
    internal InnerEither(T5 fifth)
    {
        Index = 4;
        Fifth = fifth;
    }

    /// <inheritdoc/>
    [Pure]
    public T5? Fifth { get; }

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(0, 4)]
    public int Index { get; }

    /// <inheritdoc/>
    [Pure]
    public object? Value => this[Index].Value;

    /// <inheritdoc/>
    [Pure]
    public
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ToReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => $"{nameof(Either)}[{Index}] {{ {Value} }}";
}

#endif
