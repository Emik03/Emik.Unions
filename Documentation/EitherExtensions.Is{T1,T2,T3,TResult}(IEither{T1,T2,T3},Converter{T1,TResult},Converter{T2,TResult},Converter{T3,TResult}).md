#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Is<T1,T2,T3,TResult>(this IEither<T1,T2,T3>, Converter<T1,TResult>, Converter<T2,TResult>, Converter<T3,TResult>) Method

Runs the callback based on the value of the disjoint union.

```csharp
public static TResult Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3> that, System.Converter<T1,TResult> on1, System.Converter<T2,TResult> on2, System.Converter<T3,TResult> on3);
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T3'></a>

`T3`

The third generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).TResult'></a>

`TResult`

The type for the [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') type of the callbacks.
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T1](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).T1')[,](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T2](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).T2')[,](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T3](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).T3')[&gt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).on1'></a>

`on1` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T1](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).TResult 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The callback for [that](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).that') having [First](IEither{T1,T2,T3}.First.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.First').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).on2'></a>

`on2` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T2](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).TResult 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The callback for [that](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).that') having [Second](IEither{T1,T2,T3}.Second.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.Second').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).on3'></a>

`on3` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T3](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).TResult 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The callback for [that](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).that') having [Third](IEither{T1,T2,T3}.Third.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.Third').

#### Returns
[TResult](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).TResult 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).TResult')  
The value returned from the callback that corresponded to the  
[Value](IEither.Value.md 'Emik.Unions.Disjoints.IEither.Value') of [that](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).that').

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.Is{T1,T2,T3,TResult}(IEither{T1,T2,T3},Converter{T1,TResult},Converter{T2,TResult},Converter{T3,TResult}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,TResult_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Converter_T1,TResult_,System.Converter_T2,TResult_,System.Converter_T3,TResult_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,TResult>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Converter<T1,TResult>, System.Converter<T2,TResult>, System.Converter<T3,TResult>).that') has an invalid [Index](IEither.Index.md 'Emik.Unions.Disjoints.IEither.Index').