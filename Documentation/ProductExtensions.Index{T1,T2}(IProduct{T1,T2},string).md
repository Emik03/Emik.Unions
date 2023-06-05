#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[ProductExtensions](ProductExtensions.md 'Emik.Unions.Tagged.ProductExtensions')

## ProductExtensions.Index<T1,T2>(this IProduct<T1,T2>, string) Method

Performs an index operation on the union.

```csharp
public static System.Collections.Generic.KeyValuePair<System.Reflection.PropertyInfo,object?> Index<T1,T2>(this Emik.Unions.Tagged.IProduct<T1,T2> that, string name);
```
#### Type parameters

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1,T2_(thisEmik.Unions.Tagged.IProduct_T1,T2_,string).T1'></a>

`T1`

The first generic parameter of [IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>').

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1,T2_(thisEmik.Unions.Tagged.IProduct_T1,T2_,string).T2'></a>

`T2`

The second generic parameter of [IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>').
#### Parameters

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1,T2_(thisEmik.Unions.Tagged.IProduct_T1,T2_,string).that'></a>

`that` [Emik.Unions.Tagged.IProduct&lt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T1](ProductExtensions.Index{T1,T2}(IProduct{T1,T2},string).md#Emik.Unions.Tagged.ProductExtensions.Index_T1,T2_(thisEmik.Unions.Tagged.IProduct_T1,T2_,string).T1 'Emik.Unions.Tagged.ProductExtensions.Index<T1,T2>(this Emik.Unions.Tagged.IProduct<T1,T2>, string).T1')[,](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T2](ProductExtensions.Index{T1,T2}(IProduct{T1,T2},string).md#Emik.Unions.Tagged.ProductExtensions.Index_T1,T2_(thisEmik.Unions.Tagged.IProduct_T1,T2_,string).T2 'Emik.Unions.Tagged.ProductExtensions.Index<T1,T2>(this Emik.Unions.Tagged.IProduct<T1,T2>, string).T2')[&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')

The instance of the union.

<a name='Emik.Unions.Tagged.ProductExtensions.Index_T1,T2_(thisEmik.Unions.Tagged.IProduct_T1,T2_,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name to apply.

#### Returns
[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')  
The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name of the union.

#### Exceptions

[System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
The value [name](ProductExtensions.Index{T1,T2}(IProduct{T1,T2},string).md#Emik.Unions.Tagged.ProductExtensions.Index_T1,T2_(thisEmik.Unions.Tagged.IProduct_T1,T2_,string).name 'Emik.Unions.Tagged.ProductExtensions.Index<T1,T2>(this Emik.Unions.Tagged.IProduct<T1,T2>, string).name') is not a valid member.