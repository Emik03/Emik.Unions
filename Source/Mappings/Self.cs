// SPDX-License-Identifier: MPL-2.0

// ReSharper disable WrongIndentSize
namespace Emik.Unions.Mappings;
#pragma warning disable SA1001
/// <summary>A functor that returns itself.</summary>
/// <typeparam name="T">The encapsulating type.</typeparam>
/// <param name="Value">The encapsulated value.</param>
// ReSharper disable once NotAccessedPositionalProperty.Global
public sealed record Self<T>(T Value) : Functor<T, T, Self<T>>(x => x)
#if NET7_0_OR_GREATER
       ,
        IEqualityOperators<Self<T>, Self<T>, bool>
#endif
    ;
