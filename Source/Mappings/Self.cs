#region Emik.MPL

// <copyright file="Self.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Emik.Unions.Mappings;

/// <summary>A functor that returns itself.</summary>
/// <typeparam name="T">The encapsulating type.</typeparam>
/// <param name="Value">The encapsulated value.</param>
// ReSharper disable once NotAccessedPositionalProperty.Global
public sealed record Self<T>(T Value) : Functor<T, T, Self<T>>(x => x);
