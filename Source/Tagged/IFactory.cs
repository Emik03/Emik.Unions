// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

// ReSharper disable once EmptyNamespace
namespace Emik.Unions.Tagged;
#if NET7_0_OR_GREATER
#pragma warning disable RCS1036, SA1508
/// <summary>Defines an interface for a factory method with argument length 1.</summary>
/// <typeparam name="T1">The first argument for the factory.</typeparam>
/// <typeparam name="TType">The resulting type from the factory.</typeparam>
public interface IFactory<in T1, out TType>
{
    /// <summary>Creates the new instance of <typeparamref name="TType"/> with the given arguments.</summary>
    /// <param name="first">The first argument of the factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance with the values of the arguments.</returns>
#pragma warning disable CA1000, CA1716, SA1114
    [Pure]
    static abstract TType New(
        T1 first);
#pragma warning restore CA1000, CA1716, SA1114
}

/// <summary>Defines an interface for a factory method with argument length 2.</summary>
/// <typeparam name="T1">The first argument for the factory.</typeparam>
/// <typeparam name="T2">The second argument for the factory.</typeparam>
/// <typeparam name="TType">The resulting type from the factory.</typeparam>
public interface IFactory<in T1, in T2, out TType>
{
    /// <summary>Creates the new instance of <typeparamref name="TType"/> with the given arguments.</summary>
    /// <param name="first">The first argument of the factory.</param>
    /// <param name="second">The second argument of the factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance with the values of the arguments.</returns>
#pragma warning disable CA1000, CA1716, SA1114
    [Pure]
    static abstract TType New(
        T1 first,
        T2 second);
#pragma warning restore CA1000, CA1716, SA1114
}

/// <summary>Defines an interface for a factory method with argument length 3.</summary>
/// <typeparam name="T1">The first argument for the factory.</typeparam>
/// <typeparam name="T2">The second argument for the factory.</typeparam>
/// <typeparam name="T3">The third argument for the factory.</typeparam>
/// <typeparam name="TType">The resulting type from the factory.</typeparam>
public interface IFactory<in T1, in T2, in T3, out TType>
{
    /// <summary>Creates the new instance of <typeparamref name="TType"/> with the given arguments.</summary>
    /// <param name="first">The first argument of the factory.</param>
    /// <param name="second">The second argument of the factory.</param>
    /// <param name="third">The third argument of the factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance with the values of the arguments.</returns>
#pragma warning disable CA1000, CA1716, SA1114
    [Pure]
    static abstract TType New(
        T1 first,
        T2 second,
        T3 third);
#pragma warning restore CA1000, CA1716, SA1114
}

/// <summary>Defines an interface for a factory method with argument length 4.</summary>
/// <typeparam name="T1">The first argument for the factory.</typeparam>
/// <typeparam name="T2">The second argument for the factory.</typeparam>
/// <typeparam name="T3">The third argument for the factory.</typeparam>
/// <typeparam name="T4">The fourth argument for the factory.</typeparam>
/// <typeparam name="TType">The resulting type from the factory.</typeparam>
public interface IFactory<in T1, in T2, in T3, in T4, out TType>
{
    /// <summary>Creates the new instance of <typeparamref name="TType"/> with the given arguments.</summary>
    /// <param name="first">The first argument of the factory.</param>
    /// <param name="second">The second argument of the factory.</param>
    /// <param name="third">The third argument of the factory.</param>
    /// <param name="fourth">The fourth argument of the factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance with the values of the arguments.</returns>
#pragma warning disable CA1000, CA1716, SA1114
    [Pure]
    static abstract TType New(
        T1 first,
        T2 second,
        T3 third,
        T4 fourth);
#pragma warning restore CA1000, CA1716, SA1114
}

#endif
