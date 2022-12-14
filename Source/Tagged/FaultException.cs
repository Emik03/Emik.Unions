#region Emik.MPL

// <copyright file="FaultException.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Emik.Unions.Tagged;

/// <summary>The exception type that is raised by <see cref="Fault{T}"/>.</summary>
[Serializable]
public sealed class FaultException : ArgumentException
{
    /// <summary>Initializes a new instance of the <see cref="FaultException"/> class.</summary>
    /// <param name="message">The assertion message.</param>
    /// <param name="paramName">The class responsible for creating the <see cref="Fault{T}"/>.</param>
    /// <param name="uninit">The uninitialized object.</param>
    public FaultException(string message, [InvokerParameterName] string paramName, object? uninit)
        : this(message)
    {
        Uninit = uninit;
        ParamName = paramName;
    }

    FaultException() { }

    FaultException(string? message) // ReSharper disable once IntroduceOptionalParameters.Local
        : this(message, null) { }

    FaultException(string? message, Exception? innerException)
        : base(message, innerException) { }

    FaultException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        : base(serializationInfo, streamingContext) { }

    /// <inheritdoc />
    [Pure]
    public override string ParamName { get; } = "";

    /// <summary>Gets the object that is in an invalid state.</summary>
    [Pure]
    public object? Uninit { get; }

    /// <inheritdoc />
    [Pure]
    public override string ToString() => $"Expected: {Message}, received: {Uninit} (caused by '{ParamName}')";
}
