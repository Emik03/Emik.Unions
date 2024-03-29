﻿// SPDX-License-Identifier: MPL-2.0
namespace Emik.Unions;

/// <summary>Provides an indexer.</summary>
public interface IProperties
{
    /// <summary>Gets all properties of this type.</summary>
    /// <returns>An <see cref="Array"/> of <see cref="PropertyInfo"/> instances.</returns>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> Properties { get; }

    /// <summary>
    /// Gets an <see cref="object"/> corresponding to the property of the type based on the index passed in.
    /// </summary>
    /// <param name="index">The property number to get its value.</param>
    /// <returns><see cref="object"/> corresponding to the property number <paramref name="index"/>.</returns>
    [Pure] // ReSharper disable once UnusedMemberInSuper.Global
    KeyValuePair<PropertyInfo, object?> this[[NonNegativeValue] int index] { get; }
}
