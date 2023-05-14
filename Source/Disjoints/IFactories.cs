// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

// ReSharper disable once EmptyNamespace
namespace Emik.Unions.Disjoints;
#if NET7_0_OR_GREATER
#pragma warning disable CA1000, CA1716, RCS1036, SA1114, SA1508
/// <summary>Defines an interface for 2 factory methods for each respective type.</summary>
/// <typeparam name="T1">The first argument for the factory.</typeparam>
/// <typeparam name="T2">The second argument for the factory.</typeparam>
/// <typeparam name="TType">The resulting type from the factory.</typeparam>
public interface IFactories<in T1, in T2, out TType>
{
    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T1"/>.</summary>
    /// <param name="first">The argument of the first factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T1"/>.</returns>
    static abstract TType New(T1 first);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T2"/>.</summary>
    /// <param name="second">The argument of the second factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T2"/>.</returns>
    static abstract TType New(T2 second);

}

/// <summary>Defines an interface for 3 factory methods for each respective type.</summary>
/// <typeparam name="T1">The first argument for the factory.</typeparam>
/// <typeparam name="T2">The second argument for the factory.</typeparam>
/// <typeparam name="T3">The third argument for the factory.</typeparam>
/// <typeparam name="TType">The resulting type from the factory.</typeparam>
public interface IFactories<in T1, in T2, in T3, out TType>
{
    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T1"/>.</summary>
    /// <param name="first">The argument of the first factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T1"/>.</returns>
    static abstract TType New(T1 first);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T2"/>.</summary>
    /// <param name="second">The argument of the second factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T2"/>.</returns>
    static abstract TType New(T2 second);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T3"/>.</summary>
    /// <param name="third">The argument of the third factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T3"/>.</returns>
    static abstract TType New(T3 third);

}

/// <summary>Defines an interface for 4 factory methods for each respective type.</summary>
/// <typeparam name="T1">The first argument for the factory.</typeparam>
/// <typeparam name="T2">The second argument for the factory.</typeparam>
/// <typeparam name="T3">The third argument for the factory.</typeparam>
/// <typeparam name="T4">The fourth argument for the factory.</typeparam>
/// <typeparam name="TType">The resulting type from the factory.</typeparam>
public interface IFactories<in T1, in T2, in T3, in T4, out TType>
{
    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T1"/>.</summary>
    /// <param name="first">The argument of the first factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T1"/>.</returns>
    static abstract TType New(T1 first);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T2"/>.</summary>
    /// <param name="second">The argument of the second factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T2"/>.</returns>
    static abstract TType New(T2 second);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T3"/>.</summary>
    /// <param name="third">The argument of the third factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T3"/>.</returns>
    static abstract TType New(T3 third);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T4"/>.</summary>
    /// <param name="fourth">The argument of the fourth factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T4"/>.</returns>
    static abstract TType New(T4 fourth);

}

/// <summary>Defines an interface for 5 factory methods for each respective type.</summary>
/// <typeparam name="T1">The first argument for the factory.</typeparam>
/// <typeparam name="T2">The second argument for the factory.</typeparam>
/// <typeparam name="T3">The third argument for the factory.</typeparam>
/// <typeparam name="T4">The fourth argument for the factory.</typeparam>
/// <typeparam name="T5">The fifth argument for the factory.</typeparam>
/// <typeparam name="TType">The resulting type from the factory.</typeparam>
public interface IFactories<in T1, in T2, in T3, in T4, in T5, out TType>
{
    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T1"/>.</summary>
    /// <param name="first">The argument of the first factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T1"/>.</returns>
    static abstract TType New(T1 first);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T2"/>.</summary>
    /// <param name="second">The argument of the second factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T2"/>.</returns>
    static abstract TType New(T2 second);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T3"/>.</summary>
    /// <param name="third">The argument of the third factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T3"/>.</returns>
    static abstract TType New(T3 third);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T4"/>.</summary>
    /// <param name="fourth">The argument of the fourth factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T4"/>.</returns>
    static abstract TType New(T4 fourth);

    /// <summary>Creates the new instance of <typeparamref name="TType"/> from <typeparamref name="T5"/>.</summary>
    /// <param name="fifth">The argument of the fifth factory.</param>
    /// <returns>The new <typeparamref name="TType"/> instance from <typeparamref name="T5"/>.</returns>
    static abstract TType New(T5 fifth);

}

#endif
