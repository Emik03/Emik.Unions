#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Product](Product.md 'Emik.Unions.Tagged.Product')

## Product.New<T1>(T1, Predicate<IProduct<T1>>, string) Method

Creates a [IProduct&lt;T1&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>') with the provided values.

```csharp
public static Emik.Results.Result<Emik.Unions.Tagged.IProduct<T1>,Emik.Unions.Tagged.Fault<Emik.Unions.Tagged.IProduct<T1>>> New<T1>(T1 first, System.Predicate<Emik.Unions.Tagged.IProduct<T1>>? firstPred=null, string? firstEx=null);
```
#### Type parameters

<a name='Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).T1'></a>

`T1`

The first generic parameter of [IProduct&lt;T1&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>').
#### Parameters

<a name='Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).first'></a>

`first` [T1](Product.New.E9HfqjZwUojdqloDwuUWjg.md#Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).T1 'Emik.Unions.Tagged.Product.New<T1>(T1, System.Predicate<Emik.Unions.Tagged.IProduct<T1>>, string).T1')

The first parameter to pass in the type [IProduct&lt;T1&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>').

<a name='Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).firstPred'></a>

`firstPred` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[Emik.Unions.Tagged.IProduct&lt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')[T1](Product.New.E9HfqjZwUojdqloDwuUWjg.md#Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).T1 'Emik.Unions.Tagged.Product.New<T1>(T1, System.Predicate<Emik.Unions.Tagged.IProduct<T1>>, string).T1')[&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

The first condition to assert. True is a valid state.

<a name='Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).firstEx'></a>

`firstEx` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The expression of [first](Product.New.E9HfqjZwUojdqloDwuUWjg.md#Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).first 'Emik.Unions.Tagged.Product.New<T1>(T1, System.Predicate<Emik.Unions.Tagged.IProduct<T1>>, string).first') to pass as the failure value.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[Emik.Unions.Tagged.IProduct&lt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')[T1](Product.New.E9HfqjZwUojdqloDwuUWjg.md#Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).T1 'Emik.Unions.Tagged.Product.New<T1>(T1, System.Predicate<Emik.Unions.Tagged.IProduct<T1>>, string).T1')[&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[Emik.Unions.Tagged.Fault&lt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')[Emik.Unions.Tagged.IProduct&lt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')[T1](Product.New.E9HfqjZwUojdqloDwuUWjg.md#Emik.Unions.Tagged.Product.New_T1_(T1,System.Predicate_Emik.Unions.Tagged.IProduct_T1__,string).T1 'Emik.Unions.Tagged.Product.New<T1>(T1, System.Predicate<Emik.Unions.Tagged.IProduct<T1>>, string).T1')[&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')[&gt;](Fault_T_.md 'Emik.Unions.Tagged.Fault<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
[IProduct&lt;T1&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>') with the parameters passed in.