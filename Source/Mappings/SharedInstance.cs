// <copyright file="Singleton.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Mappings;

/// <summary>Defines a singleton.</summary>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record SharedInstance<TType>
    where TType : SharedInstance<TType>
{
    static TType? s_instance;

    /// <summary>
    /// Initializes a new instance of the <see cref="SharedInstance{TType}"/> class by updating <see cref="Instance"/>.
    /// </summary>
    protected SharedInstance() => s_instance = (TType)this;

    /// <summary>Gets a value indicating whether an instance is created.</summary>
    protected static bool HasInstance => s_instance is not null;

    /// <summary>Gets the shared instance.</summary>
    protected static TType Instance => s_instance ?? throw new InvalidOperationException("Uninitialized value.");
}
