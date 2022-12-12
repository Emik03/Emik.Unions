﻿// <copyright file="IProperties.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions;

/// <summary>Provides an indexer.</summary>
public interface IProperties
{
    /// <summary>
    /// Gets an <see cref="object"/> corresponding to the property of the type based on the index passed in.
    /// </summary>
    /// <param name="index">The property number to get its value.</param>
    /// <returns><see cref="object"/> corresponding to the property number <paramref name="index"/>.</returns>
    [Pure] // ReSharper disable once UnusedMemberInSuper.Global
    KeyValuePair<PropertyInfo, object?> this[[NonNegativeValue] int index] { get; }

    /// <summary>Gets all properties of this type.</summary>
    /// <returns>An <see cref="Array"/> of <see cref="PropertyInfo"/> instances.</returns>
    [Pure]
    IReadOnlyList<PropertyInfo> Properties { get; }
}
