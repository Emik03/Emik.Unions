// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

namespace Emik.Unions.Tagged;
#pragma warning disable RCS1036, SA1508
/// <summary>Provides an indexer.</summary>
public interface IProduct : IPropertyEnumerable, IProperties
{
    /// <summary>Gets an <see cref="object"/> corresponding to the property.</summary>
    /// <param name="name">The property name to get its value.</param>
    /// <returns><see cref="object"/> corresponding to the property name <paramref name="name"/>.</returns>
    [Pure]
    object? this[PropertyInfo name] { get; }

    /// <summary>Gets an <see cref="object"/> corresponding to the name.</summary>
    /// <param name="name">The property name to get its value.</param>
    /// <returns><see cref="object"/> corresponding to the property name <paramref name="name"/>.</returns>
    [Pure]
    KeyValuePair<PropertyInfo, object?> this[[Localizable(false), LocalizationRequired(false)] string name] { get; }
}

/// <summary>Defines an interface for union of size 1.</summary>
/// <typeparam name="T1">The first type of the union.</typeparam>
public interface IProduct<out T1> : IProduct
{
    /// <summary>Gets the <typeparamref name="T1"/> first value of the union.</summary>
    [Pure]
    T1 First { get; }

}

/// <summary>Defines an interface for union of size 2.</summary>
/// <typeparam name="T1">The first type of the union.</typeparam>
/// <typeparam name="T2">The second type of the union.</typeparam>
public interface IProduct<out T1, out T2> : IProduct
{
    /// <summary>Gets the <typeparamref name="T1"/> first value of the union.</summary>
    [Pure]
    T1 First { get; }

    /// <summary>Gets the <typeparamref name="T2"/> second value of the union.</summary>
    [Pure]
    T2 Second { get; }

}

/// <summary>Defines an interface for union of size 3.</summary>
/// <typeparam name="T1">The first type of the union.</typeparam>
/// <typeparam name="T2">The second type of the union.</typeparam>
/// <typeparam name="T3">The third type of the union.</typeparam>
public interface IProduct<out T1, out T2, out T3> : IProduct
{
    /// <summary>Gets the <typeparamref name="T1"/> first value of the union.</summary>
    [Pure]
    T1 First { get; }

    /// <summary>Gets the <typeparamref name="T2"/> second value of the union.</summary>
    [Pure]
    T2 Second { get; }

    /// <summary>Gets the <typeparamref name="T3"/> third value of the union.</summary>
    [Pure]
    T3 Third { get; }

}

/// <summary>Defines an interface for union of size 4.</summary>
/// <typeparam name="T1">The first type of the union.</typeparam>
/// <typeparam name="T2">The second type of the union.</typeparam>
/// <typeparam name="T3">The third type of the union.</typeparam>
/// <typeparam name="T4">The fourth type of the union.</typeparam>
public interface IProduct<out T1, out T2, out T3, out T4> : IProduct
{
    /// <summary>Gets the <typeparamref name="T1"/> first value of the union.</summary>
    [Pure]
    T1 First { get; }

    /// <summary>Gets the <typeparamref name="T2"/> second value of the union.</summary>
    [Pure]
    T2 Second { get; }

    /// <summary>Gets the <typeparamref name="T3"/> third value of the union.</summary>
    [Pure]
    T3 Third { get; }

    /// <summary>Gets the <typeparamref name="T4"/> fourth value of the union.</summary>
    [Pure]
    T4 Fourth { get; }

}

