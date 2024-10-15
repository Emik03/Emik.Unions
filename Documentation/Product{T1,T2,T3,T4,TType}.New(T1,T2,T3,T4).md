#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Product&lt;T1,T2,T3,T4,TType&gt;](Product{T1,T2,T3,T4,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')

## Product<T1,T2,T3,T4,TType>.New(T1, T2, T3, T4) Method

Attempts to create a new instance of [TType](Product{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.TType').

```csharp
public static Emik.Results.Result<TType,Emik.Unions.Tagged.Fault<TType>> New(T1 first, T2 second, T3 third, T4 fourth);
```
#### Parameters

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.New(T1,T2,T3,T4).first'></a>

`first` [T1](Product{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T1')

The first value of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.New(T1,T2,T3,T4).second'></a>

`second` [T2](Product{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T2')

The second value of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.New(T1,T2,T3,T4).third'></a>

`third` [T3](Product{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T3')

The third value of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.New(T1,T2,T3,T4).fourth'></a>

`fourth` [T4](Product{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T4')

The fourth value of the union.

Implements [New(T1, T2, T3, T4)](IFactory{T1,T2,T3,T4,TType}.New(T1,T2,T3,T4).md 'Emik.Unions.Tagged.IFactory<T1,T2,T3,T4,TType>.New(T1, T2, T3, T4)')

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[TType](Product{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.TType')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[Emik.Unions.Tagged.Fault&lt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[TType](Product{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.TType')[&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
A new instance of [TType](Product{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.TType') which encapsulates all of the parameters.