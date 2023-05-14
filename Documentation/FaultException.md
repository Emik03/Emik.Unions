#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## FaultException Class

The exception type that is raised by [Fault&lt;T&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>').

```csharp
public sealed class FaultException : System.ArgumentException,
Emik.Results.IFatal
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [System.SystemException](https://docs.microsoft.com/en-us/dotnet/api/System.SystemException 'System.SystemException') &#129106; [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') &#129106; FaultException

Implements [Emik.Results.IFatal](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.IFatal 'Emik.Results.IFatal')

| Constructors | |
| :--- | :--- |
| [FaultException(string, string, object)](FaultException..ctor(String,String,Object).md 'Emik.Unions.Tagged.FaultException.FaultException(string, string, object)') | Initializes a new instance of the [FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException') class. |

| Properties | |
| :--- | :--- |
| [Uninit](FaultException.Uninit.md 'Emik.Unions.Tagged.FaultException.Uninit') | Gets the object that is in an invalid state. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Results.IFatal.Value](FaultException.Emik.Results.IFatal.Value.md 'Emik.Unions.Tagged.FaultException.Emik.Results.IFatal.Value') | Gets the value. |
