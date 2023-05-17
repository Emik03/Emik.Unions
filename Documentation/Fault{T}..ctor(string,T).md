#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Fault&lt;T&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')

## Fault(string, T) Constructor

A pseudo-exception-like type tossed by some other type, typically as an [Emik.Results.Result&lt;&gt;.Err](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2.Err 'Emik.Results.Result`2.Err') value.

```csharp
public Fault(string Fact, T Uninit);
```
#### Parameters

<a name='Emik.Unions.Tagged.Fault_T_.Fault(string,T).Fact'></a>

`Fact` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The expression that was asserted, but failed.

<a name='Emik.Unions.Tagged.Fault_T_.Fault(string,T).Uninit'></a>

`Uninit` [T](Fault{T}.md#Emik.Unions.Tagged.Fault_T_.T 'Emik.Unions.Tagged.Fault<T>.T')

The object that failed to initialize. Be wary that this object is in an invalid state.