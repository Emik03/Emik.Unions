#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException')

## FaultException(string, string, object) Constructor

Initializes a new instance of the [FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException') class.

```csharp
public FaultException(string message, string paramName, object? uninit);
```
#### Parameters

<a name='Emik.Unions.Tagged.FaultException.FaultException(string,string,object).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The assertion message.

<a name='Emik.Unions.Tagged.FaultException.FaultException(string,string,object).paramName'></a>

`paramName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The class responsible for creating the [Fault&lt;T&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>').

<a name='Emik.Unions.Tagged.FaultException.FaultException(string,string,object).uninit'></a>

`uninit` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The uninitialized object.