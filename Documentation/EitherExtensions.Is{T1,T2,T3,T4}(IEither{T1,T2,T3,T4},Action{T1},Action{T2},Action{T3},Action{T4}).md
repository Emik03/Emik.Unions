#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Is<T1,T2,T3,T4>(this IEither<T1,T2,T3,T4>, Action<T1>, Action<T2>, Action<T3>, Action<T4>) Method

Runs the callback based on the value of the disjoint union.

```csharp
public static Emik.Unions.Disjoints.IEither<T1,T2,T3,T4> Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4> that, System.Action<T1>? on1=null, System.Action<T2>? on2=null, System.Action<T3>? on3=null, System.Action<T4>? on4=null)
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull;
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2,T3,T4&gt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2,T3,T4&gt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T3'></a>

`T3`

The third generic parameter of [IEither&lt;T1,T2,T3,T4&gt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T4'></a>

`T4`

The fourth generic parameter of [IEither&lt;T1,T2,T3,T4&gt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T1](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T1')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T2](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T2')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T3](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T3')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T4](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T4 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T4')[&gt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).on1'></a>

`on1` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T1](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).that') having [First](IEither{T1,T2,T3,T4}.First.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>.First').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).on2'></a>

`on2` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T2](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).that') having [Second](IEither{T1,T2,T3,T4}.Second.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>.Second').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).on3'></a>

`on3` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T3](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T3')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).that') having [Third](IEither{T1,T2,T3,T4}.Third.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>.Third').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).on4'></a>

`on4` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T4](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T4 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T4')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).that') having [Fourth](IEither{T1,T2,T3,T4}.Fourth.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>.Fourth').

#### Returns
[Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T1](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T1')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T2](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T2')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T3](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T3')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T4](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).T4 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).T4')[&gt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')  
Itself.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.Is{T1,T2,T3,T4}(IEither{T1,T2,T3,T4},Action{T1},Action{T2},Action{T3},Action{T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4_,System.Action_T1_,System.Action_T2_,System.Action_T3_,System.Action_T4_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>, System.Action<T1>, System.Action<T2>, System.Action<T3>, System.Action<T4>).that') has an invalid [Index](IEither.Index.md 'Emik.Unions.Disjoints.IEither.Index').