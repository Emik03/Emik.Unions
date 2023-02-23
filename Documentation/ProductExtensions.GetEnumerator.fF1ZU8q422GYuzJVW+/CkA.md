#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[ProductExtensions](ProductExtensions.md 'Emik.Unions.Tagged.ProductExtensions')

## ProductExtensions.GetEnumerator<T1,T2,T3,T4>(this IProduct<T1,T2,T3,T4>) Method

Enumerates through a [IProduct&lt;T1,T2,T3,T4&gt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')'s values.

```csharp
public static System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Reflection.PropertyInfo,T1>> GetEnumerator<T1,T2,T3,T4>(this Emik.Unions.Tagged.IProduct<T1,T2,T3,T4> that)
    where T2 : T1
    where T3 : T1
    where T4 : T1;
```
#### Type parameters

<a name='Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T1'></a>

`T1`

The first generic parameter of [IProduct&lt;T1,T2,T3,T4&gt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>').

<a name='Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T2'></a>

`T2`

The second generic parameter of [IProduct&lt;T1,T2,T3,T4&gt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>').

<a name='Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T3'></a>

`T3`

The third generic parameter of [IProduct&lt;T1,T2,T3,T4&gt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>').

<a name='Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T4'></a>

`T4`

The fourth generic parameter of [IProduct&lt;T1,T2,T3,T4&gt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>').
#### Parameters

<a name='Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).that'></a>

`that` [Emik.Unions.Tagged.IProduct&lt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')[T1](ProductExtensions.GetEnumerator.fF1ZU8q422GYuzJVW+/CkA.md#Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T1 'Emik.Unions.Tagged.ProductExtensions.GetEnumerator<T1,T2,T3,T4>(this Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>).T1')[,](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')[T2](ProductExtensions.GetEnumerator.fF1ZU8q422GYuzJVW+/CkA.md#Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T2 'Emik.Unions.Tagged.ProductExtensions.GetEnumerator<T1,T2,T3,T4>(this Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>).T2')[,](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')[T3](ProductExtensions.GetEnumerator.fF1ZU8q422GYuzJVW+/CkA.md#Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T3 'Emik.Unions.Tagged.ProductExtensions.GetEnumerator<T1,T2,T3,T4>(this Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>).T3')[,](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')[T4](ProductExtensions.GetEnumerator.fF1ZU8q422GYuzJVW+/CkA.md#Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T4 'Emik.Unions.Tagged.ProductExtensions.GetEnumerator<T1,T2,T3,T4>(this Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>).T4')[&gt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')

The instance of the union.

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[T1](ProductExtensions.GetEnumerator.fF1ZU8q422GYuzJVW+/CkA.md#Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1,T2,T3,T4_(thisEmik.Unions.Tagged.IProduct_T1,T2,T3,T4_).T1 'Emik.Unions.Tagged.ProductExtensions.GetEnumerator<T1,T2,T3,T4>(this Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>).T1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator of objects from the items in the argument provided.