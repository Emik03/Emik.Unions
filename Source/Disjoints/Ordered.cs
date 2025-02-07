// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

#pragma warning disable CA1000, CA1033, RCS1036
namespace Emik.Unions.Disjoints;

/// <summary>Defines an inheritable record that automates logic for a disjoint union.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Ordered<T1, T2, TType> :
#if NET7_0_OR_GREATER
    IEqualityOperators<Ordered<T1, T2, TType>, Ordered<T1, T2, TType>, bool>,
    IFactories<T1, T2, TType>,
#endif
    IEither<T1, T2>
    where T1 : notnull
    where T2 : notnull
    where TType : Ordered<T1, T2, TType>, new()
{
    static readonly PropertyInfo[] s_properties = typeof(Ordered<T1, T2, TType>)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(x => x.Name is not nameof(Index) && x.GetGetMethod() is not null && x.GetSetMethod(true) is not null)
       .ToArray();

    /// <inheritdoc/>
    [Pure]
    public T1? First { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T2"/> value being set.
    /// </summary>
    /// <param name="first">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="first"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T1 first) =>
#pragma warning restore MA0018
        new()
        {
            First = first,
            Index = 0,
        };

    /// <inheritdoc/>
    [Pure]
    public T2? Second { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T2"/> value being set.
    /// </summary>
    /// <param name="second">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="second"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T2 second) =>
#pragma warning restore MA0018
        new()
        {
            Second = second,
            Index = 1,
        };

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 1)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(-1, 1)]
    public int Index { get; protected init; } = -1;

    /// <inheritdoc/>
    [Pure]
    public object? Value => this[Index].Value;

    /// <inheritdoc/>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> IProperties.Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() =>
        $"{typeof(TType).Name}[{Index}] {{ {this[Index].Value} }}";
}

/// <summary>Defines an inheritable record that automates logic for a disjoint union.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Ordered<T1, T2, T3, TType> :
#if NET7_0_OR_GREATER
    IEqualityOperators<Ordered<T1, T2, T3, TType>, Ordered<T1, T2, T3, TType>, bool>,
    IFactories<T1, T2, T3, TType>,
#endif
    IEither<T1, T2, T3>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where TType : Ordered<T1, T2, T3, TType>, new()
{
    static readonly PropertyInfo[] s_properties = typeof(Ordered<T1, T2, T3, TType>)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(x => x.Name is not nameof(Index) && x.GetGetMethod() is not null && x.GetSetMethod(true) is not null)
       .ToArray();

    /// <inheritdoc/>
    [Pure]
    public T1? First { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T3"/> value being set.
    /// </summary>
    /// <param name="first">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="first"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T1 first) =>
#pragma warning restore MA0018
        new()
        {
            First = first,
            Index = 0,
        };

    /// <inheritdoc/>
    [Pure]
    public T2? Second { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T3"/> value being set.
    /// </summary>
    /// <param name="second">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="second"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T2 second) =>
#pragma warning restore MA0018
        new()
        {
            Second = second,
            Index = 1,
        };

    /// <inheritdoc/>
    [Pure]
    public T3? Third { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T3"/> value being set.
    /// </summary>
    /// <param name="third">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="third"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T3 third) =>
#pragma warning restore MA0018
        new()
        {
            Third = third,
            Index = 2,
        };

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 2)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(-1, 2)]
    public int Index { get; protected init; } = -1;

    /// <inheritdoc/>
    [Pure]
    public object? Value => this[Index].Value;

    /// <inheritdoc/>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> IProperties.Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() =>
        $"{typeof(TType).Name}[{Index}] {{ {this[Index].Value} }}";
}

/// <summary>Defines an inheritable record that automates logic for a disjoint union.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Ordered<T1, T2, T3, T4, TType> :
#if NET7_0_OR_GREATER
    IEqualityOperators<Ordered<T1, T2, T3, T4, TType>, Ordered<T1, T2, T3, T4, TType>, bool>,
    IFactories<T1, T2, T3, T4, TType>,
#endif
    IEither<T1, T2, T3, T4>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where TType : Ordered<T1, T2, T3, T4, TType>, new()
{
    static readonly PropertyInfo[] s_properties = typeof(Ordered<T1, T2, T3, T4, TType>)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(x => x.Name is not nameof(Index) && x.GetGetMethod() is not null && x.GetSetMethod(true) is not null)
       .ToArray();

    /// <inheritdoc/>
    [Pure]
    public T1? First { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T4"/> value being set.
    /// </summary>
    /// <param name="first">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="first"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T1 first) =>
#pragma warning restore MA0018
        new()
        {
            First = first,
            Index = 0,
        };

    /// <inheritdoc/>
    [Pure]
    public T2? Second { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T4"/> value being set.
    /// </summary>
    /// <param name="second">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="second"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T2 second) =>
#pragma warning restore MA0018
        new()
        {
            Second = second,
            Index = 1,
        };

    /// <inheritdoc/>
    [Pure]
    public T3? Third { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T4"/> value being set.
    /// </summary>
    /// <param name="third">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="third"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T3 third) =>
#pragma warning restore MA0018
        new()
        {
            Third = third,
            Index = 2,
        };

    /// <inheritdoc/>
    [Pure]
    public T4? Fourth { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T4"/> value being set.
    /// </summary>
    /// <param name="fourth">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="fourth"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T4 fourth) =>
#pragma warning restore MA0018
        new()
        {
            Fourth = fourth,
            Index = 3,
        };

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 3)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(-1, 3)]
    public int Index { get; protected init; } = -1;

    /// <inheritdoc/>
    [Pure]
    public object? Value => this[Index].Value;

    /// <inheritdoc/>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> IProperties.Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() =>
        $"{typeof(TType).Name}[{Index}] {{ {this[Index].Value} }}";
}

#if !NETFRAMEWORK || NET40_OR_GREATER
/// <summary>Defines an inheritable record that automates logic for a disjoint union.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
/// <typeparam name="T5">The fifth type of the disjoint union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Ordered<T1, T2, T3, T4, T5, TType> :
#if NET7_0_OR_GREATER
    IEqualityOperators<Ordered<T1, T2, T3, T4, T5, TType>, Ordered<T1, T2, T3, T4, T5, TType>, bool>,
    IFactories<T1, T2, T3, T4, T5, TType>,
#endif
    IEither<T1, T2, T3, T4, T5>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where TType : Ordered<T1, T2, T3, T4, T5, TType>, new()
{
    static readonly PropertyInfo[] s_properties = typeof(Ordered<T1, T2, T3, T4, T5, TType>)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(x => x.Name is not nameof(Index) && x.GetGetMethod() is not null && x.GetSetMethod(true) is not null)
       .ToArray();

    /// <inheritdoc/>
    [Pure]
    public T1? First { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="first">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="first"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T1 first) =>
#pragma warning restore MA0018
        new()
        {
            First = first,
            Index = 0,
        };

    /// <inheritdoc/>
    [Pure]
    public T2? Second { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="second">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="second"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T2 second) =>
#pragma warning restore MA0018
        new()
        {
            Second = second,
            Index = 1,
        };

    /// <inheritdoc/>
    [Pure]
    public T3? Third { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="third">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="third"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T3 third) =>
#pragma warning restore MA0018
        new()
        {
            Third = third,
            Index = 2,
        };

    /// <inheritdoc/>
    [Pure]
    public T4? Fourth { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="fourth">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="fourth"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T4 fourth) =>
#pragma warning restore MA0018
        new()
        {
            Fourth = fourth,
            Index = 3,
        };

    /// <inheritdoc/>
    [Pure]
    public T5? Fifth { get; protected init; }

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="fifth">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="fifth"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T5 fifth) =>
#pragma warning restore MA0018
        new()
        {
            Fifth = fifth,
            Index = 4,
        };

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 4)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(-1, 4)]
    public int Index { get; protected init; } = -1;

    /// <inheritdoc/>
    [Pure]
    public object? Value => this[Index].Value;

    /// <inheritdoc/>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> IProperties.Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() =>
        $"{typeof(TType).Name}[{Index}] {{ {this[Index].Value} }}";
}

#endif
