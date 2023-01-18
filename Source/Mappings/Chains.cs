// SPDX-License-Identifier: MPL-2.0
namespace Emik.Unions.Mappings;

/// <summary>Allows the start of method chaining for functors.</summary>
public static class Chains
{
    /// <summary>Starts a method chaining pattern of functors.</summary>
    /// <typeparam name="T">The type to encapsulate.</typeparam>
    /// <param name="item">The item to encapsulate.</param>
    /// <returns>A <see cref="Self{T}"/> which encapsulates the parameter <paramref name="item"/>.</returns>
    public static Self<T> Chain<T>(this T item) => new(item);
}
