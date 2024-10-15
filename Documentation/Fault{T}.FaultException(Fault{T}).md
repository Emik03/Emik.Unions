#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Fault&lt;T&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')

## Fault<T>.implicit operator FaultException(Fault<T>) Operator

Converts this instance into an [FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException').  
This allows an [Fault&lt;T&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>') to be thrown just like an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception'),  
without the heap allocation for ones that aren't thrown.

```csharp
public static Emik.Unions.Tagged.FaultException implicit operator FaultException(Emik.Unions.Tagged.Fault<T> fault);
```
#### Parameters

<a name='Emik.Unions.Tagged.Fault_T_.op_ImplicitEmik.Unions.Tagged.FaultException(Emik.Unions.Tagged.Fault_T_).fault'></a>

`fault` [Emik.Unions.Tagged.Fault&lt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[T](Fault{T}.md#Emik.Unions.Tagged.Fault_T_.T 'Emik.Unions.Tagged.Fault<T>.T')[&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')

The instance to convert.

#### Returns
[FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException')  
An [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') that contains metadata from [fault](Fault{T}.FaultException(Fault{T}).md#Emik.Unions.Tagged.Fault_T_.op_ImplicitEmik.Unions.Tagged.FaultException(Emik.Unions.Tagged.Fault_T_).fault 'Emik.Unions.Tagged.Fault<T>.op_Implicit Emik.Unions.Tagged.FaultException(Emik.Unions.Tagged.Fault<T>).fault').