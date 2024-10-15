#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[ProductExtensions](ProductExtensions.md 'Emik.Unions.Tagged.ProductExtensions')

## ProductExtensions.GetEnumerator<T1>(this IProduct<T1>) Method

Enumerates through a [IProduct&lt;T1&gt;](IProduct{T1}.md 'Emik.Unions.Tagged.IProduct<T1>')'s values.

```csharp
public static System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Reflection.PropertyInfo,T1>> GetEnumerator<T1>(this Emik.Unions.Tagged.IProduct<T1> that);
```
#### Type parameters

<a name='Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1_(thisEmik.Unions.Tagged.IProduct_T1_).T1'></a>

`T1`

The first generic parameter of [IProduct&lt;T1&gt;](IProduct{T1}.md 'Emik.Unions.Tagged.IProduct<T1>').
#### Parameters

<a name='Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1_(thisEmik.Unions.Tagged.IProduct_T1_).that'></a>

`that` [Emik.Unions.Tagged.IProduct&lt;](IProduct{T1}.md 'Emik.Unions.Tagged.IProduct<T1>')[T1](ProductExtensions.GetEnumerator{T1}(IProduct{T1}).md#Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1_(thisEmik.Unions.Tagged.IProduct_T1_).T1 'Emik.Unions.Tagged.ProductExtensions.GetEnumerator<T1>(this Emik.Unions.Tagged.IProduct<T1>).T1')[&gt;](IProduct{T1}.md 'Emik.Unions.Tagged.IProduct<T1>')

The instance of the union.

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[T1](ProductExtensions.GetEnumerator{T1}(IProduct{T1}).md#Emik.Unions.Tagged.ProductExtensions.GetEnumerator_T1_(thisEmik.Unions.Tagged.IProduct_T1_).T1 'Emik.Unions.Tagged.ProductExtensions.GetEnumerator<T1>(this Emik.Unions.Tagged.IProduct<T1>).T1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator of objects from the items in the argument provided.