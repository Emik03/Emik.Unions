#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Is<T1,T2,T3,T4,T5>(this IEither<T1,T2,T3,T4,T5>, IEither<T1,T4>) Method

Determines whether the disjoint union is the type provided.

```csharp
public static bool Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5> that, out Emik.Unions.Disjoints.IEither<T1,T4>? n1n4)
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull;
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2,T3,T4,T5&gt;](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2,T3,T4,T5&gt;](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T3'></a>

`T3`

The third generic parameter of [IEither&lt;T1,T2,T3,T4,T5&gt;](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T4'></a>

`T4`

The fourth generic parameter of [IEither&lt;T1,T2,T3,T4,T5&gt;](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T5'></a>

`T5`

The fifth generic parameter of [IEither&lt;T1,T2,T3,T4,T5&gt;](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T1](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).T1')[,](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T2](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T2 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).T2')[,](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T3](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T3 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).T3')[,](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T4](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T4 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).T4')[,](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T5](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T5 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).T5')[&gt;](IEither{T1,T2,T3,T4,T5}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).n1n4'></a>

`n1n4` [Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T1](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T1 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).T1')[,](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T4](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).T4 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).T4')[&gt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')

The truthy value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [that](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).that') matches the pattern,  
otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [that](EitherExtensions.Is{T1,T2,T3,T4,T5}(IEither{T1,T2,T3,T4,T5},IEither&{T1,T4}).md#Emik.Unions.Disjoints.EitherExtensions.Is_T1,T2,T3,T4,T5_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_,Emik.Unions.Disjoints.IEither_T1,T4_).that 'Emik.Unions.Disjoints.EitherExtensions.Is<T1,T2,T3,T4,T5>(this Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>, Emik.Unions.Disjoints.IEither<T1,T4>).that') has an invalid [Index](IEither.Index.md 'Emik.Unions.Disjoints.IEither.Index').