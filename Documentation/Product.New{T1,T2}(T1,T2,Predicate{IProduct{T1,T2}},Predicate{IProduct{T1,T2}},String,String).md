#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[Product](Product.md 'Emik.Unions.Tagged.Product')

## Product.New<T1,T2>(T1, T2, Predicate<IProduct<T1,T2>>, Predicate<IProduct<T1,T2>>, string, string) Method

Creates a [IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>') with the provided values.

```csharp
public static Emik.Results.Result<Emik.Unions.Tagged.IProduct<T1,T2>,Emik.Unions.Tagged.Fault<Emik.Unions.Tagged.IProduct<T1,T2>>> New<T1,T2>(T1 first, T2 second, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>? firstPred=null, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>? secondPred=null, string? firstEx=null, string? secondEx=null);
```
#### Type parameters

<a name='Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T1'></a>

`T1`

The first generic parameter of [IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>').

<a name='Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T2'></a>

`T2`

The second generic parameter of [IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>').
#### Parameters

<a name='Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).first'></a>

`first` [T1](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T1 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T1')

The first parameter to pass in the type [IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>').

<a name='Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).second'></a>

`second` [T2](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T2 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T2')

The second parameter to pass in the type [IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>').

<a name='Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).firstPred'></a>

`firstPred` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[Emik.Unions.Tagged.IProduct&lt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T1](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T1 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T1')[,](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T2](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T2 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T2')[&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

The first condition to assert. True is a valid state.

<a name='Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).secondPred'></a>

`secondPred` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[Emik.Unions.Tagged.IProduct&lt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T1](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T1 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T1')[,](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T2](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T2 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T2')[&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

The second condition to assert. True is a valid state.

<a name='Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).firstEx'></a>

`firstEx` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The expression of [first](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).first 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).first') to pass as the failure value.

<a name='Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).secondEx'></a>

`secondEx` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The expression of [second](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).second 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).second') to pass as the failure value.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[Emik.Unions.Tagged.IProduct&lt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T1](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T1 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T1')[,](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T2](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T2 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T2')[&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[Emik.Unions.Tagged.Fault&lt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[Emik.Unions.Tagged.IProduct&lt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T1](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T1 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T1')[,](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T2](Product.New{T1,T2}(T1,T2,Predicate{IProduct{T1,T2}},Predicate{IProduct{T1,T2}},String,String).md#Emik.Unions.Tagged.Product.New_T1,T2_(T1,T2,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,System.Predicate_Emik.Unions.Tagged.IProduct_T1,T2__,string,string).T2 'Emik.Unions.Tagged.Product.New<T1,T2>(T1, T2, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, System.Predicate<Emik.Unions.Tagged.IProduct<T1,T2>>, string, string).T2')[&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
[IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>') with the parameters passed in.