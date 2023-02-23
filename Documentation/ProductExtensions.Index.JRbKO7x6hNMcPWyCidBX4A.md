#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[ProductExtensions](ProductExtensions.md 'Emik.Unions.Tagged.ProductExtensions')

## ProductExtensions.Index<T1>(this IProduct<T1>, string) Method

Performs an index operation on the union.

```csharp
public static System.Collections.Generic.KeyValuePair<System.Reflection.PropertyInfo,object?> Index<T1>(this Emik.Unions.Tagged.IProduct<T1> that, string name);
```
#### Type parameters

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,string).T1'></a>

`T1`

The first generic parameter of [IProduct&lt;T1&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>').
#### Parameters

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,string).that'></a>

`that` [Emik.Unions.Tagged.IProduct&lt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')[T1](ProductExtensions.Index.JRbKO7x6hNMcPWyCidBX4A.md#Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,string).T1 'Emik.Unions.Tagged.ProductExtensions.Index<T1>(this Emik.Unions.Tagged.IProduct<T1>, string).T1')[&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')

The instance of the union.

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name to apply.

#### Returns
[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name of the union.

#### Exceptions

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
The value [name](ProductExtensions.Index.JRbKO7x6hNMcPWyCidBX4A.md#Emik.Unions.Tagged.ProductExtensions.Index_T1_(thisEmik.Unions.Tagged.IProduct_T1_,string).name 'Emik.Unions.Tagged.ProductExtensions.Index<T1>(this Emik.Unions.Tagged.IProduct<T1>, string).name') is not a valid member.