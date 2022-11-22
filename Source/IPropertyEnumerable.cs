// <copyright file="IPropertyEnumerable.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions;

/// <summary>Provides an enumeration.</summary>
public interface IPropertyEnumerable
{
    /// <summary>Enumerates through a <see cref="IPropertyEnumerable"/>'s values.</summary>
    /// <returns>An enumerator of objects from the items in the argument provided.</returns>
    [Pure]
    public IEnumerator<KeyValuePair<PropertyInfo, object?>> Enumeration();
}
