// <copyright file="Chains.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
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
