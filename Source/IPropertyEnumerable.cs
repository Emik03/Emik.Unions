// SPDX-License-Identifier: MPL-2.0
namespace Emik.Unions;

/// <summary>Provides an enumeration.</summary>
public interface IPropertyEnumerable
{
    /// <summary>Enumerates through a <see cref="IPropertyEnumerable"/>'s values.</summary>
    /// <returns>An enumerator of objects from the items in the argument provided.</returns>
    [Pure]
    public IEnumerator<KeyValuePair<PropertyInfo, object?>> Enumeration();
}
