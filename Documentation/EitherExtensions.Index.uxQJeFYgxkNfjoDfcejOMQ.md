#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints').[EitherExtensions](EitherExtensions.md 'Emik.Unions.Disjoints.EitherExtensions')

## EitherExtensions.Index<T1,T2,T3>(this IEither<T1,T2,T3>, int) Method

Performs an index operation on the disjoint union.

```csharp
public static System.Collections.Generic.KeyValuePair<System.Reflection.PropertyInfo,object?> Index<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3> that, int index);
```
#### Type parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).T1'></a>

`T1`

The first generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).T2'></a>

`T2`

The second generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).T3'></a>

`T3`

The third generic parameter of [IEither&lt;T1,T2,T3&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>').
#### Parameters

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).that'></a>

`that` [Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T1](EitherExtensions.Index.uxQJeFYgxkNfjoDfcejOMQ.md#Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).T1 'Emik.Unions.Disjoints.EitherExtensions.Index<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, int).T1')[,](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T2](EitherExtensions.Index.uxQJeFYgxkNfjoDfcejOMQ.md#Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).T2 'Emik.Unions.Disjoints.EitherExtensions.Index<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, int).T2')[,](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')[T3](EitherExtensions.Index.uxQJeFYgxkNfjoDfcejOMQ.md#Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).T3 'Emik.Unions.Disjoints.EitherExtensions.Index<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, int).T3')[&gt;](IEither_T1,T2,T3_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>')

The instance of the disjoint union.

<a name='Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index to apply.

#### Returns
[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the index of the disjoint union.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [index](EitherExtensions.Index.uxQJeFYgxkNfjoDfcejOMQ.md#Emik.Unions.Disjoints.EitherExtensions.Index_T1,T2,T3_(thisEmik.Unions.Disjoints.IEither_T1,T2,T3_,int).index 'Emik.Unions.Disjoints.EitherExtensions.Index<T1,T2,T3>(this Emik.Unions.Disjoints.IEither<T1,T2,T3>, int).index') is out of range.