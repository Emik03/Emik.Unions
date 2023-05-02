#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Product&lt;T1,T2,TType&gt;](Product_T1,T2,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')

## Product<T1,T2,TType>.New(T1, T2) Method

Attempts to create a new instance of [TType](Product_T1,T2,TType_.md#Emik.Unions.Tagged.Product_T1,T2,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,TType>.TType').

```csharp
public static Result<TType,Emik.Unions.Tagged.Fault<TType>> New(T1 first, T2 second);
```
#### Parameters

<a name='Emik.Unions.Tagged.Product_T1,T2,TType_.New(T1,T2).first'></a>

`first` [T1](Product_T1,T2,TType_.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,TType>.T1')

The first value of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,TType_.New(T1,T2).second'></a>

`second` [T2](Product_T1,T2,TType_.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,TType>.T2')

The second value of the union.

#### Returns
[Emik.Results.Result](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result 'Emik.Results.Result')  
A new instance of [TType](Product_T1,T2,TType_.md#Emik.Unions.Tagged.Product_T1,T2,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,TType>.TType') which encapsulates all of the parameters.