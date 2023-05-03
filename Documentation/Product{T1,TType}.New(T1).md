#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Product&lt;T1,TType&gt;](Product{T1,TType}.md 'Emik.Unions.Tagged.Product<T1,TType>')

## Product<T1,TType>.New(T1) Method

Attempts to create a new instance of [TType](Product{T1,TType}.md#Emik.Unions.Tagged.Product_T1,TType_.TType 'Emik.Unions.Tagged.Product<T1,TType>.TType').

```csharp
public static Emik.Results.Result<TType,Emik.Unions.Tagged.Fault<TType>> New(T1 first);
```
#### Parameters

<a name='Emik.Unions.Tagged.Product_T1,TType_.New(T1).first'></a>

`first` [T1](Product{T1,TType}.md#Emik.Unions.Tagged.Product_T1,TType_.T1 'Emik.Unions.Tagged.Product<T1,TType>.T1')

The first value of the union.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[TType](Product{T1,TType}.md#Emik.Unions.Tagged.Product_T1,TType_.TType 'Emik.Unions.Tagged.Product<T1,TType>.TType')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[Emik.Unions.Tagged.Fault&lt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[TType](Product{T1,TType}.md#Emik.Unions.Tagged.Product_T1,TType_.TType 'Emik.Unions.Tagged.Product<T1,TType>.TType')[&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
A new instance of [TType](Product{T1,TType}.md#Emik.Unions.Tagged.Product_T1,TType_.TType 'Emik.Unions.Tagged.Product<T1,TType>.TType') which encapsulates all of the parameters.