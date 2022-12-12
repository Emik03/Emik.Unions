// <copyright file="Singleton.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Mappings;

/// <summary>Defines a singleton.</summary>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record SharedInstance<TType>
    where TType : SharedInstance<TType>
{
    const string New = nameof(New);

    /// <summary>
    /// Gets or sets the method used to create an instance of <typeparamref name="TType"/> without parameters.
    /// This is meant to be set in a static constructor to intercept the creation of <see cref="Instance"/>.
    /// </summary>
    static readonly Func<TType> s_new =
        (typeof(TType).GetProperty(New, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy) ??
            throw new MissingMethodException(typeof(TType).Name, New)).GetValue(null, null) as Func<TType> ??
        throw new ArgumentNullException(New);

    static TType? s_instance;

    /// <summary>
    /// Initializes a new instance of the <see cref="SharedInstance{TType}"/> class by updating <see cref="Instance"/>.
    /// </summary>
    protected SharedInstance() => s_instance = (TType)this;

    /// <summary>Gets the shared instance.</summary>
    protected static TType Instance => s_instance ?? s_new();
}
