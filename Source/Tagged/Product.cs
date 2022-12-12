// ReSharper disable ArrangeConstructorOrDestructorBody BadParensLineBreaks BadPreprocessorIndent IncorrectBlankLinesNearBraces MissingIndent RedundantCast RedundantLinebreak UnusedMemberInSuper.Global
// ReSharper disable MissingLinebreak
// <copyright file="Product.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Unions.Tagged;
#pragma warning disable RCS1036, SA1508
/// <summary>A static class that provides methods for creating new instances of union types.</summary>
public static class Product
{
    /// <summary>Creates a <see cref="IProduct{T1}"/> with the provided values.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1}"/>.
    /// </typeparam>
    /// <param name="first">
    /// The first parameter to pass in the type <see cref="IProduct{T1}"/>.
    /// </param>
    /// <param name="firstPred">The first condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <returns><see cref="IProduct{T1}"/> with the parameters passed in.</returns>
    [MustUseReturnValue]
    public static Result<IProduct<T1>, Fault<IProduct<T1>>> New<T1>(
        T1 first,
        [RequireStaticDelegate] Predicate<IProduct<T1>>? firstPred = null,
        [CallerArgumentExpression(nameof(firstPred))] string? firstEx = null)
        =>
            new InnerProduct<T1>(
                first) is var product &&
            (
                !firstPred?.Invoke(product) ?? false ? firstEx :
                null
            ) is { } err
                ? new Fault<IProduct<T1>>(err, product)
                : product;

    /// <summary>Creates a <see cref="IProduct{T1, T2}"/> with the provided values.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2}"/>.
    /// </typeparam>
    /// <param name="first">
    /// The first parameter to pass in the type <see cref="IProduct{T1, T2}"/>.
    /// </param>
    /// <param name="second">
    /// The second parameter to pass in the type <see cref="IProduct{T1, T2}"/>.
    /// </param>
    /// <param name="firstPred">The first condition to assert. True is a valid state.</param>
    /// <param name="secondPred">The second condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <returns><see cref="IProduct{T1, T2}"/> with the parameters passed in.</returns>
    [MustUseReturnValue]
    public static Result<IProduct<T1, T2>, Fault<IProduct<T1, T2>>> New<T1, T2>(
        T1 first,
        T2 second,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2>>? firstPred = null,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2>>? secondPred = null,
        [CallerArgumentExpression(nameof(firstPred))] string? firstEx = null,
        [CallerArgumentExpression(nameof(secondPred))] string? secondEx = null)
        =>
            new InnerProduct<T1, T2>(
                first,
                second) is var product &&
            (
                !firstPred?.Invoke(product) ?? false ? firstEx :
                !secondPred?.Invoke(product) ?? false ? secondEx :
                null
            ) is { } err
                ? new Fault<IProduct<T1, T2>>(err, product)
                : product;

    /// <summary>Creates a <see cref="IProduct{T1, T2, T3}"/> with the provided values.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IProduct{T1, T2, T3}"/>.
    /// </typeparam>
    /// <param name="first">
    /// The first parameter to pass in the type <see cref="IProduct{T1, T2, T3}"/>.
    /// </param>
    /// <param name="second">
    /// The second parameter to pass in the type <see cref="IProduct{T1, T2, T3}"/>.
    /// </param>
    /// <param name="third">
    /// The third parameter to pass in the type <see cref="IProduct{T1, T2, T3}"/>.
    /// </param>
    /// <param name="firstPred">The first condition to assert. True is a valid state.</param>
    /// <param name="secondPred">The second condition to assert. True is a valid state.</param>
    /// <param name="thirdPred">The third condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <returns><see cref="IProduct{T1, T2, T3}"/> with the parameters passed in.</returns>
    [MustUseReturnValue]
    public static Result<IProduct<T1, T2, T3>, Fault<IProduct<T1, T2, T3>>> New<T1, T2, T3>(
        T1 first,
        T2 second,
        T3 third,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2, T3>>? firstPred = null,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2, T3>>? secondPred = null,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2, T3>>? thirdPred = null,
        [CallerArgumentExpression(nameof(firstPred))] string? firstEx = null,
        [CallerArgumentExpression(nameof(secondPred))] string? secondEx = null,
        [CallerArgumentExpression(nameof(thirdPred))] string? thirdEx = null)
        =>
            new InnerProduct<T1, T2, T3>(
                first,
                second,
                third) is var product &&
            (
                !firstPred?.Invoke(product) ?? false ? firstEx :
                !secondPred?.Invoke(product) ?? false ? secondEx :
                !thirdPred?.Invoke(product) ?? false ? thirdEx :
                null
            ) is { } err
                ? new Fault<IProduct<T1, T2, T3>>(err, product)
                : product;

    /// <summary>Creates a <see cref="IProduct{T1, T2, T3, T4}"/> with the provided values.</summary>
    /// <typeparam name="T1">
    /// The first generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T3">
    /// The third generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <typeparam name="T4">
    /// The fourth generic parameter of <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </typeparam>
    /// <param name="first">
    /// The first parameter to pass in the type <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </param>
    /// <param name="second">
    /// The second parameter to pass in the type <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </param>
    /// <param name="third">
    /// The third parameter to pass in the type <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </param>
    /// <param name="fourth">
    /// The fourth parameter to pass in the type <see cref="IProduct{T1, T2, T3, T4}"/>.
    /// </param>
    /// <param name="firstPred">The first condition to assert. True is a valid state.</param>
    /// <param name="secondPred">The second condition to assert. True is a valid state.</param>
    /// <param name="thirdPred">The third condition to assert. True is a valid state.</param>
    /// <param name="fourthPred">The fourth condition to assert. True is a valid state.</param>
    /// <param name="firstEx">
    /// The expression of <paramref name="first"/> to pass as the failure value.
    /// </param>
    /// <param name="secondEx">
    /// The expression of <paramref name="second"/> to pass as the failure value.
    /// </param>
    /// <param name="thirdEx">
    /// The expression of <paramref name="third"/> to pass as the failure value.
    /// </param>
    /// <param name="fourthEx">
    /// The expression of <paramref name="fourth"/> to pass as the failure value.
    /// </param>
    /// <returns><see cref="IProduct{T1, T2, T3, T4}"/> with the parameters passed in.</returns>
    [MustUseReturnValue]
    public static Result<IProduct<T1, T2, T3, T4>, Fault<IProduct<T1, T2, T3, T4>>> New<T1, T2, T3, T4>(
        T1 first,
        T2 second,
        T3 third,
        T4 fourth,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2, T3, T4>>? firstPred = null,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2, T3, T4>>? secondPred = null,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2, T3, T4>>? thirdPred = null,
        [RequireStaticDelegate] Predicate<IProduct<T1, T2, T3, T4>>? fourthPred = null,
        [CallerArgumentExpression(nameof(firstPred))] string? firstEx = null,
        [CallerArgumentExpression(nameof(secondPred))] string? secondEx = null,
        [CallerArgumentExpression(nameof(thirdPred))] string? thirdEx = null,
        [CallerArgumentExpression(nameof(fourthPred))] string? fourthEx = null)
        =>
            new InnerProduct<T1, T2, T3, T4>(
                first,
                second,
                third,
                fourth) is var product &&
            (
                !firstPred?.Invoke(product) ?? false ? firstEx :
                !secondPred?.Invoke(product) ?? false ? secondEx :
                !thirdPred?.Invoke(product) ?? false ? thirdEx :
                !fourthPred?.Invoke(product) ?? false ? fourthEx :
                null
            ) is { } err
                ? new Fault<IProduct<T1, T2, T3, T4>>(err, product)
                : product;

}
