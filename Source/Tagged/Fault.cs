// SPDX-License-Identifier: MPL-2.0
namespace Emik.Unions.Tagged;

/// <summary>
/// A pseudo-exception-like type tossed by some other type, typically as an <see cref="Result{TOk,TErr}.Err"/> value.
/// </summary>
/// <param name="Fact">The expression that was asserted, but failed.</param>
/// <param name="Uninit">The object that failed to initialize. Be wary that this object is in an invalid state.</param>
/// <typeparam name="T">The type that created this instance.</typeparam>
public readonly record struct Fault<T>(string Fact, T Uninit)
{
    /// <summary>
    /// Converts this instance into an <see cref="FaultException"/>, then downcasting as <see cref="Exception"/>.
    /// This allows an <see cref="Fault{T}"/> to be thrown just like an <see cref="Exception"/>,
    /// without the heap allocation for ones that aren't thrown.
    /// </summary>
    /// <param name="fault">The instance to convert.</param>
    /// <returns>An <see cref="Exception"/> that contains metadata from <paramref name="fault"/>.</returns>
    [Pure]
    public static implicit operator Exception(Fault<T> fault) => (FaultException)fault;

    /// <summary>
    /// Converts this instance into an <see cref="FaultException"/>.
    /// This allows an <see cref="Fault{T}"/> to be thrown just like an <see cref="Exception"/>,
    /// without the heap allocation for ones that aren't thrown.
    /// </summary>
    /// <param name="fault">The instance to convert.</param>
    /// <returns>An <see cref="Exception"/> that contains metadata from <paramref name="fault"/>.</returns>
    [Pure]
    public static implicit operator FaultException(Fault<T> fault) =>
        new(fault.Fact, typeof(T).Name, fault.Uninit)
        {
            Data =
            {
                [typeof(Fault<>)] = fault,
            },
        };

    /// <inheritdoc />
    [Pure]
    public override string ToString() => $"Expected: {Fact}, received: {Uninit}";
}
