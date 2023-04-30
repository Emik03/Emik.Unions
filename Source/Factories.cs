// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

namespace Emik.Unions;
#pragma warning disable RCS1036, SA1508
/// <summary>Generates factories for types.</summary>
public static class Factories
{
    /// <summary>Creates a factory from a given type.</summary>
    /// <typeparam name="T1">The first type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="TType">The type to create the factory from.</typeparam>
    /// <exception cref="MissingMemberException">
    /// There is no constructor on <typeparamref name="TType"/> that matches the signature of the return factory.
    /// </exception>
    /// <returns>A generated factory.</returns>
    [MustUseReturnValue]
    public static Result<Func<T1, TType>, MissingMethodException> From<T1, TType>()
        where TType : notnull
    {
        var info = typeof(TType).GetConstructor(new[] { typeof(T1) });

        if (info is null)
            return new MissingMethodException(
                typeof(TType).Name,
                ".ctor(T1)"
            );

        var exFirst = Expression.Parameter(typeof(T1), "first");

        var exNew = Expression.New(
                info,
                exFirst)
        ;

        return Expression
           .Lambda<Func<T1, TType>>(
                exNew,
                exFirst
           )
          .Compile();
    }

    /// <summary>Creates a factory from a given type.</summary>
    /// <typeparam name="T1">The first type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T2">The second type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="TType">The type to create the factory from.</typeparam>
    /// <exception cref="MissingMemberException">
    /// There is no constructor on <typeparamref name="TType"/> that matches the signature of the return factory.
    /// </exception>
    /// <returns>A generated factory.</returns>
    [MustUseReturnValue]
    public static Result<Func<T1, T2, TType>, MissingMethodException> From<T1, T2, TType>()
        where TType : notnull
    {
        var info = typeof(TType).GetConstructor(new[] { typeof(T1), typeof(T2) });

        if (info is null)
            return new MissingMethodException(
                typeof(TType).Name,
                ".ctor(T1, T2)"
            );

        var exFirst = Expression.Parameter(typeof(T1), "first");
        var exSecond = Expression.Parameter(typeof(T2), "second");

        var exNew = Expression.New(
                info,
                exFirst,
                exSecond)
        ;

        return Expression
           .Lambda<Func<T1, T2, TType>>(
                exNew,
                exFirst,
                exSecond
           )
          .Compile();
    }

    /// <summary>Creates a factory from a given type.</summary>
    /// <typeparam name="T1">The first type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T2">The second type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T3">The third type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="TType">The type to create the factory from.</typeparam>
    /// <exception cref="MissingMemberException">
    /// There is no constructor on <typeparamref name="TType"/> that matches the signature of the return factory.
    /// </exception>
    /// <returns>A generated factory.</returns>
    [MustUseReturnValue]
    public static Result<Func<T1, T2, T3, TType>, MissingMethodException> From<T1, T2, T3, TType>()
        where TType : notnull
    {
        var info = typeof(TType).GetConstructor(new[] { typeof(T1), typeof(T2), typeof(T3) });

        if (info is null)
            return new MissingMethodException(
                typeof(TType).Name,
                ".ctor(T1, T2, T3)"
            );

        var exFirst = Expression.Parameter(typeof(T1), "first");
        var exSecond = Expression.Parameter(typeof(T2), "second");
        var exThird = Expression.Parameter(typeof(T3), "third");

        var exNew = Expression.New(
                info,
                exFirst,
                exSecond,
                exThird)
        ;

        return Expression
           .Lambda<Func<T1, T2, T3, TType>>(
                exNew,
                exFirst,
                exSecond,
                exThird
           )
          .Compile();
    }

    /// <summary>Creates a factory from a given type.</summary>
    /// <typeparam name="T1">The first type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T2">The second type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T3">The third type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T4">The fourth type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="TType">The type to create the factory from.</typeparam>
    /// <exception cref="MissingMemberException">
    /// There is no constructor on <typeparamref name="TType"/> that matches the signature of the return factory.
    /// </exception>
    /// <returns>A generated factory.</returns>
    [MustUseReturnValue]
    public static Result<Func<T1, T2, T3, T4, TType>, MissingMethodException> From<T1, T2, T3, T4, TType>()
        where TType : notnull
    {
        var info = typeof(TType).GetConstructor(new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) });

        if (info is null)
            return new MissingMethodException(
                typeof(TType).Name,
                ".ctor(T1, T2, T3, T4)"
            );

        var exFirst = Expression.Parameter(typeof(T1), "first");
        var exSecond = Expression.Parameter(typeof(T2), "second");
        var exThird = Expression.Parameter(typeof(T3), "third");
        var exFourth = Expression.Parameter(typeof(T4), "fourth");

        var exNew = Expression.New(
                info,
                exFirst,
                exSecond,
                exThird,
                exFourth)
        ;

        return Expression
           .Lambda<Func<T1, T2, T3, T4, TType>>(
                exNew,
                exFirst,
                exSecond,
                exThird,
                exFourth
           )
          .Compile();
    }

#if !NET35
    /// <summary>Creates a factory from a given type.</summary>
    /// <typeparam name="T1">The first type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T2">The second type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T3">The third type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T4">The fourth type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="T5">The fifth type of <typeparamref name="TType"/>.</typeparam>
    /// <typeparam name="TType">The type to create the factory from.</typeparam>
    /// <exception cref="MissingMemberException">
    /// There is no constructor on <typeparamref name="TType"/> that matches the signature of the return factory.
    /// </exception>
    /// <returns>A generated factory.</returns>
    [MustUseReturnValue]
    public static Result<Func<T1, T2, T3, T4, T5, TType>, MissingMethodException> From<T1, T2, T3, T4, T5, TType>()
        where TType : notnull
    {
        var info = typeof(TType).GetConstructor(new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) });

        if (info is null)
            return new MissingMethodException(
                typeof(TType).Name,
                ".ctor(T1, T2, T3, T4, T5)"
            );

        var exFirst = Expression.Parameter(typeof(T1), "first");
        var exSecond = Expression.Parameter(typeof(T2), "second");
        var exThird = Expression.Parameter(typeof(T3), "third");
        var exFourth = Expression.Parameter(typeof(T4), "fourth");
        var exFifth = Expression.Parameter(typeof(T5), "fifth");

        var exNew = Expression.New(
                info,
                exFirst,
                exSecond,
                exThird,
                exFourth,
                exFifth)
        ;

        return Expression
           .Lambda<Func<T1, T2, T3, T4, T5, TType>>(
                exNew,
                exFirst,
                exSecond,
                exThird,
                exFourth,
                exFifth
           )
          .Compile();
    }

#endif
}
