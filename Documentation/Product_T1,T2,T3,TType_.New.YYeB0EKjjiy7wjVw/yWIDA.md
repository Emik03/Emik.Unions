#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Product&lt;T1,T2,T3,TType&gt;](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>')

## Product<T1,T2,T3,TType>.New(T1, T2, T3) Method

Attempts to create a new instance of [TType](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.TType').

```csharp
public static Emik.Results.Result<TType,Emik.Unions.Tagged.Fault<TType>> New(T1 first, T2 second, T3 third);
```
#### Parameters

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,TType_.New(T1,T2,T3).first'></a>

`first` [T1](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T1')

The first value of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,TType_.New(T1,T2,T3).second'></a>

`second` [T2](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T2')

The second value of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,TType_.New(T1,T2,T3).third'></a>

`third` [T3](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T3 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T3')

The third value of the union.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[TType](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.TType')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[Emik.Unions.Tagged.Fault&lt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')[TType](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.TType')[&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
A new instance of [TType](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.TType') which encapsulates all of the parameters.