// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

namespace Emik.Unions.Tagged;

/// <summary>A static class that provides functionality for union types.</summary>
public static class ProductExtensions
{
    /// <summary>Performs an index operation on the union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <param name="index">The index to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the index of the union.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The value <paramref name="index"/> is out of range.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1>(
        this IProduct<T1> that,
        [ValueRange(0, 0)] int index) =>
        index switch
        {
            0 => new(that.Properties[0], that.First),
            _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-1."),
        };

    /// <summary>Performs an index operation on the union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <param name="name">The name to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the name of the union.</returns>
    /// <exception cref="KeyNotFoundException">The value <paramref name="name"/> is not a valid member.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1>(
        this IProduct<T1> that,
        [Localizable(false), LocalizationRequired(false)] string name) =>
        name switch
        {
            { } when name.Equals(that.Properties[0].Name, StringComparison.Ordinal)
                => new(that.Properties[0], that.First),
            _ => throw new KeyNotFoundException($"The key {name} is not a valid member."),
        };

    /// <summary>Enumerates through a <see cref="IProduct{T1}"/>'s values.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <returns>An enumerator of objects from the items in the argument provided.</returns>
    [LinqTunnel, Pure]
    public static IEnumerator<KeyValuePair<PropertyInfo, T1>> GetEnumerator<T1>(
        this IProduct<T1> that
    )
    {
        yield return new(that.Properties[0], that.First);
    }

    /// <summary>Performs an index operation on the union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <param name="index">The index to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the index of the union.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The value <paramref name="index"/> is out of range.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2>(
        this IProduct<T1, T2> that,
        [ValueRange(0, 1)] int index) =>
        index switch
        {
            0 => new(that.Properties[0], that.First),
            1 => new(that.Properties[1], that.Second),
            _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-2."),
        };

    /// <summary>Performs an index operation on the union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <param name="name">The name to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the name of the union.</returns>
    /// <exception cref="KeyNotFoundException">The value <paramref name="name"/> is not a valid member.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2>(
        this IProduct<T1, T2> that,
        [Localizable(false), LocalizationRequired(false)] string name) =>
        name switch
        {
            { } when name.Equals(that.Properties[0].Name, StringComparison.Ordinal)
                => new(that.Properties[0], that.First),
            { } when name.Equals(that.Properties[1].Name, StringComparison.Ordinal)
                => new(that.Properties[1], that.Second),
            _ => throw new KeyNotFoundException($"The key {name} is not a valid member."),
        };

    /// <summary>Enumerates through a <see cref="IProduct{T1, T2}"/>'s values.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <returns>An enumerator of objects from the items in the argument provided.</returns>
    [LinqTunnel, Pure]
    public static IEnumerator<KeyValuePair<PropertyInfo, T1>> GetEnumerator<T1, T2>(
        this IProduct<T1, T2> that
    )
        where T2 : T1
    {
        yield return new(that.Properties[0], that.First);
        yield return new(that.Properties[1], that.Second);
    }

    /// <summary>Performs an index operation on the union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <param name="index">The index to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the index of the union.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The value <paramref name="index"/> is out of range.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2, T3>(
        this IProduct<T1, T2, T3> that,
        [ValueRange(0, 2)] int index) =>
        index switch
        {
            0 => new(that.Properties[0], that.First),
            1 => new(that.Properties[1], that.Second),
            2 => new(that.Properties[2], that.Third),
            _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-3."),
        };

    /// <summary>Performs an index operation on the union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <param name="name">The name to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the name of the union.</returns>
    /// <exception cref="KeyNotFoundException">The value <paramref name="name"/> is not a valid member.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2, T3>(
        this IProduct<T1, T2, T3> that,
        [Localizable(false), LocalizationRequired(false)] string name) =>
        name switch
        {
            { } when name.Equals(that.Properties[0].Name, StringComparison.Ordinal)
                => new(that.Properties[0], that.First),
            { } when name.Equals(that.Properties[1].Name, StringComparison.Ordinal)
                => new(that.Properties[1], that.Second),
            { } when name.Equals(that.Properties[2].Name, StringComparison.Ordinal)
                => new(that.Properties[2], that.Third),
            _ => throw new KeyNotFoundException($"The key {name} is not a valid member."),
        };

    /// <summary>Enumerates through a <see cref="IProduct{T1, T2, T3}"/>'s values.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <returns>An enumerator of objects from the items in the argument provided.</returns>
    [LinqTunnel, Pure]
    public static IEnumerator<KeyValuePair<PropertyInfo, T1>> GetEnumerator<T1, T2, T3>(
        this IProduct<T1, T2, T3> that
    )
        where T2 : T1
        where T3 : T1
    {
        yield return new(that.Properties[0], that.First);
        yield return new(that.Properties[1], that.Second);
        yield return new(that.Properties[2], that.Third);
    }

    /// <summary>Performs an index operation on the union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <param name="index">The index to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the index of the union.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The value <paramref name="index"/> is out of range.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2, T3, T4>(
        this IProduct<T1, T2, T3, T4> that,
        [ValueRange(0, 3)] int index) =>
        index switch
        {
            0 => new(that.Properties[0], that.First),
            1 => new(that.Properties[1], that.Second),
            2 => new(that.Properties[2], that.Third),
            3 => new(that.Properties[3], that.Fourth),
            _ => throw new ArgumentOutOfRangeException(nameof(that), $"The index {index} was attempted to be accessed when the expected range is (inclusive min, exclusive max) 0-4."),
        };

    /// <summary>Performs an index operation on the union.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <param name="name">The name to apply.</param>
    /// <returns>The <see cref="object"/> corresponding to the name of the union.</returns>
    /// <exception cref="KeyNotFoundException">The value <paramref name="name"/> is not a valid member.</exception>
    [Pure]
    public static KeyValuePair<PropertyInfo, object?> Index<T1, T2, T3, T4>(
        this IProduct<T1, T2, T3, T4> that,
        [Localizable(false), LocalizationRequired(false)] string name) =>
        name switch
        {
            { } when name.Equals(that.Properties[0].Name, StringComparison.Ordinal)
                => new(that.Properties[0], that.First),
            { } when name.Equals(that.Properties[1].Name, StringComparison.Ordinal)
                => new(that.Properties[1], that.Second),
            { } when name.Equals(that.Properties[2].Name, StringComparison.Ordinal)
                => new(that.Properties[2], that.Third),
            { } when name.Equals(that.Properties[3].Name, StringComparison.Ordinal)
                => new(that.Properties[3], that.Fourth),
            _ => throw new KeyNotFoundException($"The key {name} is not a valid member."),
        };

    /// <summary>Enumerates through a <see cref="IProduct{T1, T2, T3, T4}"/>'s values.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <param name="that">The instance of the union.</param>
    /// <returns>An enumerator of objects from the items in the argument provided.</returns>
    [LinqTunnel, Pure]
    public static IEnumerator<KeyValuePair<PropertyInfo, T1>> GetEnumerator<T1, T2, T3, T4>(
        this IProduct<T1, T2, T3, T4> that
    )
        where T2 : T1
        where T3 : T1
        where T4 : T1
    {
        yield return new(that.Properties[0], that.First);
        yield return new(that.Properties[1], that.Second);
        yield return new(that.Properties[2], that.Third);
        yield return new(that.Properties[3], that.Fourth);
    }

    /// <summary>Enumerates through a <see cref="IPropertyEnumerable"/>'s values.</summary>
    /// <param name="that">The instance of the union.</param>
    /// <returns>An enumerator of objects from the items in the argument provided.</returns>
    [Pure]
    public static IEnumerator<KeyValuePair<PropertyInfo, object?>> GetEnumerator(this IPropertyEnumerable that)
        =>
            that.Enumeration();
}
