// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

namespace Emik.Unions.Tagged;
#pragma warning disable IDE0021, RCS1036
/// <summary>
/// Defines an internal union for storing 1 different values.
/// Instances of this type are exposed to the consumer as an interface.
/// </summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
sealed record InnerProduct<T1> :
#if NET7_0_OR_GREATER
    IEqualityOperators<InnerProduct<T1>, InnerProduct<T1>, bool>,
#endif
    IProduct<T1>
{
    static readonly PropertyInfo[] s_properties = typeof(InnerProduct<T1>)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public);

    /// <summary>Initializes a new instance of the <see cref="InnerProduct{T1}"/> class.</summary>
    /// <param name="first">The first parameter to pass in the union.</param>
    internal InnerProduct(
        T1 first)
    {
        First = first;
    }

    /// <inheritdoc/>
    [Pure]
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc/>
    [Pure]
    public T1 First { get; }

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

    /// <inheritdoc />
    public override string ToString() => $"{nameof(Product)} {{ {First} }}";

    /// <inheritdoc/>
    [LinqTunnel, Pure]
    public IEnumerator<KeyValuePair<PropertyInfo, object?>> Enumeration()
    {
        yield return new(s_properties[0], First);
    }
}

/// <summary>
/// Defines an internal union for storing 2 different values.
/// Instances of this type are exposed to the consumer as an interface.
/// </summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
sealed record InnerProduct<T1, T2> :
#if NET7_0_OR_GREATER
    IEqualityOperators<InnerProduct<T1, T2>, InnerProduct<T1, T2>, bool>,
#endif
    IProduct<T1, T2>
{
    static readonly PropertyInfo[] s_properties = typeof(InnerProduct<T1, T2>)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public);

    /// <summary>Initializes a new instance of the <see cref="InnerProduct{T1, T2}"/> class.</summary>
    /// <param name="first">The first parameter to pass in the union.</param>
    /// <param name="second">The second parameter to pass in the union.</param>
    internal InnerProduct(
        T1 first,
        T2 second)
    {
        First = first;
        Second = second;
    }

    /// <inheritdoc/>
    [Pure]
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc/>
    [Pure]
    public T1 First { get; }

    /// <inheritdoc/>
    [Pure]
    public T2 Second { get; }

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

    /// <inheritdoc />
    public override string ToString() => $"{nameof(Product)} {{ {First}, {Second} }}";

    /// <inheritdoc/>
    [LinqTunnel, Pure]
    public IEnumerator<KeyValuePair<PropertyInfo, object?>> Enumeration()
    {
        yield return new(s_properties[0], First);
        yield return new(s_properties[1], Second);
    }
}

/// <summary>
/// Defines an internal union for storing 3 different values.
/// Instances of this type are exposed to the consumer as an interface.
/// </summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
sealed record InnerProduct<T1, T2, T3> :
#if NET7_0_OR_GREATER
    IEqualityOperators<InnerProduct<T1, T2, T3>, InnerProduct<T1, T2, T3>, bool>,
#endif
    IProduct<T1, T2, T3>
{
    static readonly PropertyInfo[] s_properties = typeof(InnerProduct<T1, T2, T3>)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public);

    /// <summary>Initializes a new instance of the <see cref="InnerProduct{T1, T2, T3}"/> class.</summary>
    /// <param name="first">The first parameter to pass in the union.</param>
    /// <param name="second">The second parameter to pass in the union.</param>
    /// <param name="third">The third parameter to pass in the union.</param>
    internal InnerProduct(
        T1 first,
        T2 second,
        T3 third)
    {
        First = first;
        Second = second;
        Third = third;
    }

    /// <inheritdoc/>
    [Pure]
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc/>
    [Pure]
    public T1 First { get; }

    /// <inheritdoc/>
    [Pure]
    public T2 Second { get; }

    /// <inheritdoc/>
    [Pure]
    public T3 Third { get; }

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

    /// <inheritdoc />
    public override string ToString() => $"{nameof(Product)} {{ {First}, {Second}, {Third} }}";

    /// <inheritdoc/>
    [LinqTunnel, Pure]
    public IEnumerator<KeyValuePair<PropertyInfo, object?>> Enumeration()
    {
        yield return new(s_properties[0], First);
        yield return new(s_properties[1], Second);
        yield return new(s_properties[2], Third);
    }
}

/// <summary>
/// Defines an internal union for storing 4 different values.
/// Instances of this type are exposed to the consumer as an interface.
/// </summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
sealed record InnerProduct<T1, T2, T3, T4> :
#if NET7_0_OR_GREATER
    IEqualityOperators<InnerProduct<T1, T2, T3, T4>, InnerProduct<T1, T2, T3, T4>, bool>,
#endif
    IProduct<T1, T2, T3, T4>
{
    static readonly PropertyInfo[] s_properties = typeof(InnerProduct<T1, T2, T3, T4>)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public);

    /// <summary>Initializes a new instance of the <see cref="InnerProduct{T1, T2, T3, T4}"/> class.</summary>
    /// <param name="first">The first parameter to pass in the union.</param>
    /// <param name="second">The second parameter to pass in the union.</param>
    /// <param name="third">The third parameter to pass in the union.</param>
    /// <param name="fourth">The fourth parameter to pass in the union.</param>
    internal InnerProduct(
        T1 first,
        T2 second,
        T3 third,
        T4 fourth)
    {
        First = first;
        Second = second;
        Third = third;
        Fourth = fourth;
    }

    /// <inheritdoc/>
    [Pure]
    public object? this[PropertyInfo name] => this.Index(name.Name).Value;

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] =>
        this.Index(name);

    /// <inheritdoc/>
    [Pure]
    public T1 First { get; }

    /// <inheritdoc/>
    [Pure]
    public T2 Second { get; }

    /// <inheritdoc/>
    [Pure]
    public T3 Third { get; }

    /// <inheritdoc/>
    [Pure]
    public T4 Fourth { get; }

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

    /// <inheritdoc />
    public override string ToString() => $"{nameof(Product)} {{ {First}, {Second}, {Third}, {Fourth} }}";

    /// <inheritdoc/>
    [LinqTunnel, Pure]
    public IEnumerator<KeyValuePair<PropertyInfo, object?>> Enumeration()
    {
        yield return new(s_properties[0], First);
        yield return new(s_properties[1], Second);
        yield return new(s_properties[2], Third);
        yield return new(s_properties[3], Fourth);
    }
}

