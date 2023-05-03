#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.InnerType<T1,T2,T3>(this IEither<T1,T2,T3>) Method

Gets the [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of [Value](IEither.Value.md 'Emik.Unions.Disjoints.IEither.Value').

```csharp
public static System.Type InnerType<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3> that);
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_).T3'></a>

`T3`

The third generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T1](EitherExtensions.InnerType{T1,T2,T3}(IEither{T1,T2,T3}).md#Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_).T1 'Emik.Unions.Disjoints.EitherExtensions.InnerType<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>).T1')[,](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T2](EitherExtensions.InnerType{T1,T2,T3}(IEither{T1,T2,T3}).md#Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_).T2 'Emik.Unions.Disjoints.EitherExtensions.InnerType<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>).T2')[,](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T3](EitherExtensions.InnerType{T1,T2,T3}(IEither{T1,T2,T3}).md#Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_).T3 'Emik.Unions.Disjoints.EitherExtensions.InnerType<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>).T3')[&gt;](IEither{T1,T2,T3}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')

The instance of the disjoint union.

#### Returns
[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of the [Value](IEither.Value.md 'Emik.Unions.Disjoints.IEither.Value').

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.InnerType{T1,T2,T3}(IEither{T1,T2,T3}).md#Emik.Unions.Disjoints.EitherExtensions.InnerType_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_).that 'Emik.Unions.Disjoints.EitherExtensions.InnerType<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>).that') has an invalid [Index](IEither.Index.md 'Emik.Unions.Disjoints.IEither.Index').