// SPDX-License-Identifier: MPL-2.0
// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent NotAccessedPositionalProperty.Global RedundantCast RedundantLinebreak UnusedMemberInSuper.Global

#pragma warning disable CA1000, CA1033, RCS1036
namespace Emik.Unions.Disjoints;

/// <summary>Defines an inheritable record that automates logic for a disjoint union.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Either<T1, T2, TType> : IEither<T1, T2>
    where T1 : notnull
    where T2 : notnull
    where TType : Either<T1, T2, TType>
{
    int _index = -1;

    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(x => x.GetGetMethod() is not null && x.GetSetMethod() is not null)
       .ToArray();

    static readonly Func<T1?, T2?, TType> s_factory =
        Factories.From<T1?, T2?, TType>().Expect();

    static readonly Converter<TType, T1?> s_firstGetter =
        (Converter<TType, T1?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T1?>),
            s_properties[0].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T1? IEither<T1, T2>.First => s_firstGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T2"/> value being set.
    /// </summary>
    /// <param name="first">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="first"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T1 first)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            first,
            default);

        instance._index = 0;

        return instance;
    }

    static readonly Converter<TType, T2?> s_secondGetter =
        (Converter<TType, T2?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T2?>),
            s_properties[1].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T2? IEither<T1, T2>.Second => s_secondGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T2"/> value being set.
    /// </summary>
    /// <param name="second">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="second"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T2 second)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            second);

        instance._index = 1;

        return instance;
    }

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 1)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(-1, 1)]
    int IEither.Index => _index;

    /// <inheritdoc/>
    [Pure]
    object? IEither.Value => this[_index].Value;

    /// <inheritdoc/>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> IProperties.Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ToReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() =>
        $"{typeof(TType).Name}[{_index}] {{ {s_properties[_index].Name} = {this[_index]} }}";
}

/// <summary>Defines an inheritable record that automates logic for a disjoint union.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Either<T1, T2, T3, TType> : IEither<T1, T2, T3>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where TType : Either<T1, T2, T3, TType>
{
    int _index = -1;

    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(x => x.GetGetMethod() is not null && x.GetSetMethod() is not null)
       .ToArray();

    static readonly Func<T1?, T2?, T3?, TType> s_factory =
        Factories.From<T1?, T2?, T3?, TType>().Expect();

    static readonly Converter<TType, T1?> s_firstGetter =
        (Converter<TType, T1?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T1?>),
            s_properties[0].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T1? IEither<T1, T2, T3>.First => s_firstGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T3"/> value being set.
    /// </summary>
    /// <param name="first">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="first"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T1 first)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            first,
            default,
            default);

        instance._index = 0;

        return instance;
    }

    static readonly Converter<TType, T2?> s_secondGetter =
        (Converter<TType, T2?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T2?>),
            s_properties[1].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T2? IEither<T1, T2, T3>.Second => s_secondGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T3"/> value being set.
    /// </summary>
    /// <param name="second">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="second"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T2 second)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            second,
            default);

        instance._index = 1;

        return instance;
    }

    static readonly Converter<TType, T3?> s_thirdGetter =
        (Converter<TType, T3?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T3?>),
            s_properties[2].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T3? IEither<T1, T2, T3>.Third => s_thirdGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T3"/> value being set.
    /// </summary>
    /// <param name="third">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="third"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T3 third)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            default,
            third);

        instance._index = 2;

        return instance;
    }

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 2)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(-1, 2)]
    int IEither.Index => _index;

    /// <inheritdoc/>
    [Pure]
    object? IEither.Value => this[_index].Value;

    /// <inheritdoc/>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> IProperties.Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ToReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() =>
        $"{typeof(TType).Name}[{_index}] {{ {s_properties[_index].Name} = {this[_index]} }}";
}

/// <summary>Defines an inheritable record that automates logic for a disjoint union.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Either<T1, T2, T3, T4, TType> : IEither<T1, T2, T3, T4>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where TType : Either<T1, T2, T3, T4, TType>
{
    int _index = -1;

    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(x => x.GetGetMethod() is not null && x.GetSetMethod() is not null)
       .ToArray();

    static readonly Func<T1?, T2?, T3?, T4?, TType> s_factory =
        Factories.From<T1?, T2?, T3?, T4?, TType>().Expect();

    static readonly Converter<TType, T1?> s_firstGetter =
        (Converter<TType, T1?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T1?>),
            s_properties[0].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T1? IEither<T1, T2, T3, T4>.First => s_firstGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T4"/> value being set.
    /// </summary>
    /// <param name="first">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="first"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T1 first)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            first,
            default,
            default,
            default);

        instance._index = 0;

        return instance;
    }

    static readonly Converter<TType, T2?> s_secondGetter =
        (Converter<TType, T2?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T2?>),
            s_properties[1].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T2? IEither<T1, T2, T3, T4>.Second => s_secondGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T4"/> value being set.
    /// </summary>
    /// <param name="second">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="second"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T2 second)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            second,
            default,
            default);

        instance._index = 1;

        return instance;
    }

    static readonly Converter<TType, T3?> s_thirdGetter =
        (Converter<TType, T3?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T3?>),
            s_properties[2].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T3? IEither<T1, T2, T3, T4>.Third => s_thirdGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T4"/> value being set.
    /// </summary>
    /// <param name="third">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="third"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T3 third)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            default,
            third,
            default);

        instance._index = 2;

        return instance;
    }

    static readonly Converter<TType, T4?> s_fourthGetter =
        (Converter<TType, T4?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T4?>),
            s_properties[3].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T4? IEither<T1, T2, T3, T4>.Fourth => s_fourthGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T4"/> value being set.
    /// </summary>
    /// <param name="fourth">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="fourth"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T4 fourth)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            default,
            default,
            fourth);

        instance._index = 3;

        return instance;
    }

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 3)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(-1, 3)]
    int IEither.Index => _index;

    /// <inheritdoc/>
    [Pure]
    object? IEither.Value => this[_index].Value;

    /// <inheritdoc/>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> IProperties.Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ToReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() =>
        $"{typeof(TType).Name}[{_index}] {{ {s_properties[_index].Name} = {this[_index]} }}";
}

#if !NETFRAMEWORK || NET40_OR_GREATER
/// <summary>Defines an inheritable record that automates logic for a disjoint union.</summary>
/// <typeparam name="T1">The first type of the disjoint union.</typeparam>
/// <typeparam name="T2">The second type of the disjoint union.</typeparam>
/// <typeparam name="T3">The third type of the disjoint union.</typeparam>
/// <typeparam name="T4">The fourth type of the disjoint union.</typeparam>
/// <typeparam name="T5">The fifth type of the disjoint union.</typeparam>
/// <typeparam name="TType">The type of the inheriting record.</typeparam>
public abstract record Either<T1, T2, T3, T4, T5, TType> : IEither<T1, T2, T3, T4, T5>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where TType : Either<T1, T2, T3, T4, T5, TType>
{
    int _index = -1;

    static readonly PropertyInfo[] s_properties = typeof(TType)
       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
       .Where(x => x.GetGetMethod() is not null && x.GetSetMethod() is not null)
       .ToArray();

    static readonly Func<T1?, T2?, T3?, T4?, T5?, TType> s_factory =
        Factories.From<T1?, T2?, T3?, T4?, T5?, TType>().Expect();

    static readonly Converter<TType, T1?> s_firstGetter =
        (Converter<TType, T1?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T1?>),
            s_properties[0].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T1? IEither<T1, T2, T3, T4, T5>.First => s_firstGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="first">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="first"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T1 first)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            first,
            default,
            default,
            default,
            default);

        instance._index = 0;

        return instance;
    }

    static readonly Converter<TType, T2?> s_secondGetter =
        (Converter<TType, T2?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T2?>),
            s_properties[1].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T2? IEither<T1, T2, T3, T4, T5>.Second => s_secondGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="second">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="second"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T2 second)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            second,
            default,
            default,
            default);

        instance._index = 1;

        return instance;
    }

    static readonly Converter<TType, T3?> s_thirdGetter =
        (Converter<TType, T3?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T3?>),
            s_properties[2].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T3? IEither<T1, T2, T3, T4, T5>.Third => s_thirdGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="third">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="third"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T3 third)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            default,
            third,
            default,
            default);

        instance._index = 2;

        return instance;
    }

    static readonly Converter<TType, T4?> s_fourthGetter =
        (Converter<TType, T4?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T4?>),
            s_properties[3].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T4? IEither<T1, T2, T3, T4, T5>.Fourth => s_fourthGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="fourth">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="fourth"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T4 fourth)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            default,
            default,
            fourth,
            default);

        instance._index = 3;

        return instance;
    }

    static readonly Converter<TType, T5?> s_fifthGetter =
        (Converter<TType, T5?>)Delegate.CreateDelegate(
            typeof(Converter<TType, T5?>),
            s_properties[4].GetGetMethod() ?? throw Unreachable
        );

    /// <inheritdoc/>
    [Pure]
    T5? IEither<T1, T2, T3, T4, T5>.Fifth => s_fifthGetter((TType)this);

    /// <summary>
    /// Creates a new instance of <typeparamref name="TType"/> with
    /// the <typeparamref name="T5"/> value being set.
    /// </summary>
    /// <param name="fifth">The value of the disjoint union.</param>
    /// <returns>
    /// A new instance of <typeparamref name="TType"/> which contains <paramref name="fifth"/>.
    /// </returns>
    [Pure]
#pragma warning disable MA0018 // Normally a code smell, though this class is abstract and meant to be inherited anyway.
    public static TType New(T5 fifth)
#pragma warning restore MA0018
    {
        var instance = s_factory(
            default,
            default,
            default,
            default,
            fifth);

        instance._index = 4;

        return instance;
    }

    /// <inheritdoc/>
    [Pure]
    public KeyValuePair<PropertyInfo, object?> this[[ValueRange(0, 4)] int index] => this.Index(index);

    /// <inheritdoc/>
    [Pure, ValueRange(-1, 4)]
    int IEither.Index => _index;

    /// <inheritdoc/>
    [Pure]
    object? IEither.Value => this[_index].Value;

    /// <inheritdoc/>
    [Pure]
#if NETFRAMEWORK && !NET45_OR_GREATER
    IList
#else
    IReadOnlyList
#endif
        <PropertyInfo> IProperties.Properties =>
        s_properties
#if NETFRAMEWORK && !NET45_OR_GREATER
           .ToList();
#else
           .ToReadOnly();
#endif

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() =>
        $"{typeof(TType).Name}[{_index}] {{ {s_properties[_index].Name} = {this[_index]} }}";
}

#endif
