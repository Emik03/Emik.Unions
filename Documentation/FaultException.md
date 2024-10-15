#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## FaultException Class

The exception type that is raised by [Fault&lt;T&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>').

```csharp
public sealed class FaultException : System.ArgumentException,
Emik.Unions.Tagged.IFactory<string, string, object?, Emik.Unions.Tagged.FaultException>,
Emik.Results.IFatal
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [System.SystemException](https://docs.microsoft.com/en-us/dotnet/api/System.SystemException 'System.SystemException') &#129106; [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') &#129106; FaultException

Implements [Emik.Unions.Tagged.IFactory&lt;](IFactory{T1,T2,T3,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,T3,TType>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](IFactory{T1,T2,T3,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,T3,TType>')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](IFactory{T1,T2,T3,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,T3,TType>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](IFactory{T1,T2,T3,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,T3,TType>')[FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException')[&gt;](IFactory{T1,T2,T3,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,T3,TType>'), [Emik.Results.IFatal](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.IFatal 'Emik.Results.IFatal')

| Constructors | |
| :--- | :--- |
| [FaultException(string, string, object)](FaultException..ctor(string,string,object).md 'Emik.Unions.Tagged.FaultException.FaultException(string, string, object)') | Initializes a new instance of the [FaultException](FaultException.md 'Emik.Unions.Tagged.FaultException') class. |

| Properties | |
| :--- | :--- |
| [Uninit](FaultException.Uninit.md 'Emik.Unions.Tagged.FaultException.Uninit') | Gets the object that is in an invalid state. |
