// SPDX-License-Identifier: MPL-2.0
namespace Emik.Unions.Mappings;

/// <summary>A functor that returns itself.</summary>
/// <typeparam name="T">The encapsulating type.</typeparam>
/// <param name="Value">The encapsulated value.</param>
// ReSharper disable once NotAccessedPositionalProperty.Global
public sealed record Self<T>(T Value) : Functor<T, T, Self<T>>(x => x);
