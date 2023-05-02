#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## Fault<T> Struct

A pseudo-exception-like type tossed by some other type, typically as an [Emik.Results.Result&lt;&gt;.Err](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2.Err 'Emik.Results.Result`2.Err') value.

```csharp
public readonly struct Fault<T> :
System.IEquatable<Emik.Unions.Tagged.Fault<T>>
```
#### Type parameters

<a name='Emik.Unions.Tagged.Fault_T_.T'></a>

`T`

The type that created this instance.

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Tagged.Fault&lt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')[T](Fault_T_.md#Emik.Unions.Tagged.Fault_T_.T 'Emik.Unions.Tagged.Fault<T>.T')[&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Fault(string, T)](Fault_T_..ctor(String,T).md 'Emik.Unions.Tagged.Fault<T>.Fault(string, T)') | A pseudo-exception-like type tossed by some other type, typically as an [Emik.Results.Result&lt;&gt;.Err](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2.Err 'Emik.Results.Result`2.Err') value. |

| Properties | |
| :--- | :--- |
| [Fact](Fault_T_.Fact().md 'Emik.Unions.Tagged.Fault<T>.Fact') | The expression that was asserted, but failed. |
| [Uninit](Fault_T_.Uninit().md 'Emik.Unions.Tagged.Fault<T>.Uninit') | The object that failed to initialize. Be wary that this object is in an invalid state. |

| Operators | |
| :--- | :--- |
| [implicit operator FaultException(Fault&lt;T&gt;)](Fault_T_.op_Implicit(Fault).md 'Emik.Unions.Tagged.Fault<T>.op_Implicit Emik.Unions.Tagged.FaultException(Emik.Unions.Tagged.Fault<T>)') | Converts this instance into an [FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException').<br/>This allows an [Fault&lt;T&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>') to be thrown just like an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception'),<br/>without the heap allocation for ones that aren't thrown. |
| [implicit operator Exception(Fault&lt;T&gt;)](Fault_T_.op_Implicit(Fault).md 'Emik.Unions.Tagged.Fault<T>.op_Implicit System.Exception(Emik.Unions.Tagged.Fault<T>)') | Converts this instance into an [FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException'), then downcasting as [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').<br/>This allows an [Fault&lt;T&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>') to be thrown just like an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception'),<br/>without the heap allocation for ones that aren't thrown. |
