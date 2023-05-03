#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Index<T1,T2>(this IEither<T1,T2>, int) Method

Performs an index operation on the disjoint union.

```csharp
public static System.Collections.Generic.KeyValuePair<System.Reflection.PropertyInfo,object?> Index<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2> that, int index);
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,int).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2&gt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,int).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2&gt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,int).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T1](EitherExtensions.Index{T1,T2}(IEither{T1,T2},Int32).md#Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,int).T1 'Emik.Unions.Disjoints.EitherExtensions.Index<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, int).T1')[,](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T2](EitherExtensions.Index{T1,T2}(IEither{T1,T2},Int32).md#Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,int).T2 'Emik.Unions.Disjoints.EitherExtensions.Index<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, int).T2')[&gt;](IEither{T1,T2}.md 'Emik.Unions.Disjoints.IEither<T1,T2>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,int).index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index to apply.

#### Returns
[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the index of the disjoint union.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [index](EitherExtensions.Index{T1,T2}(IEither{T1,T2},Int32).md#Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2_(thisEmik.Unions.Disjoints.IEither_T1,T2_,int).index 'Emik.Unions.Disjoints.EitherExtensions.Index<T1,T2>(this Emik.Unions.Disjoints.IEither<T1,T2>, int).index') is out of range.