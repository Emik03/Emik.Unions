#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[ProductExtensions](ProductExtensions.md 'Emik.Unions.Tagged.ProductExtensions')

## ProductExtensions.Index<T1>(this IProduct<T1>, int) Method

Performs an index operation on the union.

```csharp
public static System.Collections.Generic.KeyValuePair<System.Reflection.PropertyInfo,object?> Index<T1>(this Emik.Unions.Tagged.IProduct<T1> that, int index);
```
#### Type parameters

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,int).T1'></a>

`T1`

The first generic parameter of [IProduct&lt;T1&gt;](IProduct{T1}.md 'Emik.Unions.Tagged.IProduct<T1>').
#### Parameters

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,int).that'></a>

`that` [Emik.Unions.Tagged.IProduct&lt;](IProduct{T1}.md 'Emik.Unions.Tagged.IProduct<T1>')[T1](ProductExtensions.Index{T1}(IProduct{T1},int).md#Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,int).T1 'Emik.Unions.Tagged.ProductExtensions.Index<T1>(this Emik.Unions.Tagged.IProduct<T1>, int).T1')[&gt;](IProduct{T1}.md 'Emik.Unions.Tagged.IProduct<T1>')

The instance of the union.

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,int).index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index to apply.

#### Returns
[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the index of the union.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The value [index](ProductExtensions.Index{T1}(IProduct{T1},int).md#Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,int).index 'Emik.Unions.Tagged.ProductExtensions.Index<T1>(this Emik.Unions.Tagged.IProduct<T1>, int).index') is out of range.