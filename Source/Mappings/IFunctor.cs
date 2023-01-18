// SPDX-License-Identifier: MPL-2.0
namespace Emik.Unions.Mappings;

/// <summary>
/// A functor with an unspecified result type to allow for better type inference.
/// Currently used in <see cref="Functor{T, TResult, TType}.To{TFunctor}"/>.
/// </summary>
/// <typeparam name="T">The input type.</typeparam>
/// <typeparam name="TType">The type of the implementor.</typeparam>
public interface IFunctor<
#if !NET35
    in
#endif
    T,
#if !NET35
    out
#endif
    TType>
    where TType : IFunctor<T, TType>
{
    /// <summary>Gets the factory that creates a <typeparamref name="TType"/> out of <typeparamref name="T"/>.</summary>
    [Pure]
    Converter<T, TType> Factory { get; }
}
