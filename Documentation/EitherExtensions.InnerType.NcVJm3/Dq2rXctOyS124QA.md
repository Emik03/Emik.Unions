#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.InnerType<T1,T2>(this IEither<T1,T2>) Method

Gets the [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of [Value](IEither.Value.md 'Emik.Unions.Disjoints.IEither.Value').

```csharp
public static System.Type InnerType<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2> that);
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>').

<a name='Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T1](EitherExtensions.InnerType.NcVJm3/Dq2rXctOyS124QA.md#Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_).T1 'Emik.Unions.Disjoints.EitherExtensions.InnerType<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>).T1')[,](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T2](EitherExtensions.InnerType.NcVJm3/Dq2rXctOyS124QA.md#Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_).T2 'Emik.Unions.Disjoints.EitherExtensions.InnerType<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>).T2')[&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')

The instance of the disjoint union.

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of the [Value](IEither.Value.md 'Emik.Unions.Disjoints.IEither.Value').

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.InnerType.NcVJm3/Dq2rXctOyS124QA.md#Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_).that 'Emik.Unions.Disjoints.EitherExtensions.InnerType<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>).that') has an invalid [Index](IEither.Index.md 'Emik.Unions.Disjoints.IEither.Index').