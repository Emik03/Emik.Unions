#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Is<T1,T2,TResult>(this IEither<T1,T2>, Converter<T1,TResult>, Converter<T2,TResult>) Method

Runs the callback based on the value of the disjoint union.

```csharp
public static TResult Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2> that, System.Converter<T1,TResult> on1, System.Converter<T2,TResult> on2)
    where T1 : notnull
    where T2 : notnull;
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2&gt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2&gt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).TResult'></a>

`TResult`

The type for the [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') type of the callbacks.
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T1](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).T1')[,](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T2](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).T2')[&gt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).on1'></a>

`on1` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T1](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).TResult 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The callback for [that](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).that') having [First](IEither{T1,T2}.First.md 'Emik.Unions.Disjoints.IEither<T1,T2>.First').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).on2'></a>

`on2` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T2](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).TResult 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The callback for [that](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).that') having [Second](IEither{T1,T2}.Second.md 'Emik.Unions.Disjoints.IEither<T1,T2>.Second').

#### Returns
[TResult](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).TResult 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).TResult')  
The value returned from the callback that corresponded to the  
[Value](IEither.Value.md 'Emik.Unions.Disjoints.IEither.Value') of [that](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).that').

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.Is{T1,T2,TResult}(IEither{T1,T2},Converter{T1,TResult},Converter{T2,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Converter_T1,TResult_,System.Converter_T2,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Converter<T1,TResult>, System.Converter<T2,TResult>).that') has an invalid [Index](IEither.Index.md 'Emik.Unions.Disjoints.IEither.Index').