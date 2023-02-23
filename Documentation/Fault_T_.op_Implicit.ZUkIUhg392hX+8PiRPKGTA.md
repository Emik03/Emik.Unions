#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Fault&lt;T&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')

## Fault<T>.implicit operator Exception(Fault<T>) Operator

Converts this instance into an [FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException'), then downcasting as [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
This allows an [Fault&lt;T&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>') to be thrown just like an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception'),  
without the heap allocation for ones that aren't thrown.

```csharp
public static System.Exception implicit operator Exception(Emik.Unions.Tagged.Fault<T> fault);
```
#### Parameters

<a name='Emik.Unions.Tagged.Fault_T_.op_ImplicitSystem.Exception(Emik.Unions.Tagged.Fault_T_).fault'></a>

`fault` [Emik.Unions.Tagged.Fault&lt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')[T](Fault_T_.md#Emik.Unions.Tagged.Fault_T_.T 'Emik.Unions.Tagged.Fault<T>.T')[&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')

The instance to convert.

#### Returns
[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
An [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') that contains metadata from [fault](Fault_T_.op_Implicit.ZUkIUhg392hX+8PiRPKGTA.md#Emik.Unions.Tagged.Fault_T_.op_ImplicitSystem.Exception(Emik.Unions.Tagged.Fault_T_).fault 'Emik.Unions.Tagged.Fault<T>.op_Implicit System.Exception(Emik.Unions.Tagged.Fault<T>).fault').