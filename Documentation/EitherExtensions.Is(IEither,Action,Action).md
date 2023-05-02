#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Is<T1,T2>(this IEither<T1,T2>, Action<T1>, Action<T2>) Method

Runs the callback based on the value of the disjoint union.

```csharp
public static Emik.Unions.Disjoints.IEither<T1,T2> Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2> that, System.Action<T1>? on1=null, System.Action<T2>? on2=null);
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T1](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).T1')[,](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T2](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).T2')[&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).on1'></a>

`on1` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T1](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).T1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).that') having [First](IEither_T1,T2_.First().md 'Emik.Unions.Disjoints.IEither<T1,T2>.First').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).on2'></a>

`on2` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T2](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback for [that](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).that') having [Second](IEither_T1,T2_.Second().md 'Emik.Unions.Disjoints.IEither<T1,T2>.Second').

#### Returns
[Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T1](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).T1')[,](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T2](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).T2')[&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')  
Itself.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.Is(IEither,Action,Action).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,System.Action_T1_,System.Action_T2_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, System.Action<T1>, System.Action<T2>).that') has an invalid [Index](IEither.Index().md 'Emik.Unions.Disjoints.IEither.Index').