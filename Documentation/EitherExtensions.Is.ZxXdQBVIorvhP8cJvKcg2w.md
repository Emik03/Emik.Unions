#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Is<T1,T2,T3>(this IEither<T1,T2,T3>, Action<T1>, Action<T2>, Action<T3>) Method

Runs the callback based on the value of the disjoint union.

```csharp
public static Emik.Unions.Disjoints.IEither<T1,T2,T3> Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3> that, System.Action<T1>? on1=null, System.Action<T2>? on2=null, System.Action<T3>? on3=null);
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T3'></a>

`T3`

The third generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T1](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T1')[,](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T2](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T2')[,](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T3](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T3')[&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).on1'></a>

`on1` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T1](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).that') having [First](IEither_T1,T2,T3_.First.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.First').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).on2'></a>

`on2` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T2](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).that') having [Second](IEither_T1,T2,T3_.Second.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.Second').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).on3'></a>

`on3` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T3](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T3')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).that') having [Third](IEither_T1,T2,T3_.Third.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.Third').

#### Returns
[Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T1](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T1')[,](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T2](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T2')[,](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T3](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).T3')[&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')  
Itself.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.Is.ZxXdQBVIorvhP8cJvKcg2w.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,System.Action_T1_,System.Action_T2_,System.Action_T3_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, System.Action<T1>, System.Action<T2>, System.Action<T3>).that') has an invalid [Index](IEither.Index.md 'Emik.Unions.Disjoints.IEither.Index').