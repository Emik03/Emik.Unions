#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[ProductExtensions](ProductExtensions.md 'Emik.Unions.Tagged.ProductExtensions')

## ProductExtensions.GetEnumerator(this IPropertyEnumerable) Method

Enumerates through a [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable')'s values.

```csharp
public static System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Reflection.PropertyInfo,object?>> GetEnumerator(this Emik.Unions.IPropertyEnumerable that);
```
#### Parameters

<a name='Emik.Unions.Tagged.ProductExtensions.GetEnumerator(thisEmik.Unions.IPropertyEnumerable).that'></a>

`that` [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable')

The instance of the union.

#### Returns
[System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')  
An enumerator of objects from the items in the argument provided.