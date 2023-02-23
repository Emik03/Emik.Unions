#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Is<T1,T2,T3>(this IEither<T1,T2,T3>, IEither<T1,T2>, T3) Method

Determines whether the disjoint union is the type provided.

```csharp
public static bool Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3> that, out Emik.Unions.Disjoints.IEither<T1,T2>? n1n2, out T3? n3);
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T3'></a>

`T3`

The third generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T1](EitherExtensions.Is.D3et6tVmX7etZyZ34+v4Vw.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, Emik.Unions.Disjoints.IEither<T1,T2>, T3).T1')[,](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T2](EitherExtensions.Is.D3et6tVmX7etZyZ34+v4Vw.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, Emik.Unions.Disjoints.IEither<T1,T2>, T3).T2')[,](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T3](EitherExtensions.Is.D3et6tVmX7etZyZ34+v4Vw.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, Emik.Unions.Disjoints.IEither<T1,T2>, T3).T3')[&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).n1n2'></a>

`n1n2` [Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T1](EitherExtensions.Is.D3et6tVmX7etZyZ34+v4Vw.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, Emik.Unions.Disjoints.IEither<T1,T2>, T3).T1')[,](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T2](EitherExtensions.Is.D3et6tVmX7etZyZ34+v4Vw.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, Emik.Unions.Disjoints.IEither<T1,T2>, T3).T2')[&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')

The truthy value.

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).n3'></a>

`n3` [T3](EitherExtensions.Is.D3et6tVmX7etZyZ34+v4Vw.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, Emik.Unions.Disjoints.IEither<T1,T2>, T3).T3')

The falsy value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [that](EitherExtensions.Is.D3et6tVmX7etZyZ34+v4Vw.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, Emik.Unions.Disjoints.IEither<T1,T2>, T3).that') matches the pattern,  
otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.Is.D3et6tVmX7etZyZ34+v4Vw.md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,Emik.Unions.Disjoints.IEither_T1,T2_,T3).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, Emik.Unions.Disjoints.IEither<T1,T2>, T3).that') has an invalid [Index](IEither.Index.md 'Emik.Unions.Disjoints.IEither.Index').