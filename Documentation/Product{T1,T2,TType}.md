#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## Product<T1,T2,TType> Class

Defines an inheritable record that automates logic for a union.

```csharp
public abstract class Product<T1,T2,TType> :
System.Numerics.IEqualityOperators<Emik.Unions.Tagged.Product<T1, T2, TType>, Emik.Unions.Tagged.Product<T1, T2, TType>, bool>,
Emik.Unions.Tagged.IFactory<T1, T2, Emik.Results.Result<TType, Emik.Unions.Tagged.Fault<TType>>>,
Emik.Unions.Tagged.IProduct<T1, T2>,
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties,
System.IEquatable<Emik.Unions.Tagged.Product<T1, T2, TType>>
    where TType : Emik.Unions.Tagged.Product<T1, T2, TType>
```
#### Type parameters

<a name='Emik.Unions.Tagged.Product_T1,T2,TType_.T1'></a>

`T1`

The first type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,TType_.T2'></a>

`T2`

The second type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Product<T1,T2,TType>

Implements [System.Numerics.IEqualityOperators&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Tagged.Product&lt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[T1](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,TType>.T1')[,](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[T2](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,TType>.T2')[,](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[TType](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,TType>.TType')[&gt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Tagged.Product&lt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[T1](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,TType>.T1')[,](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[T2](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,TType>.T2')[,](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[TType](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,TType>.TType')[&gt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3'), [Emik.Unions.Tagged.IFactory&lt;](IFactory{T1,T2,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,TType>')[T1](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,TType>.T1')[,](IFactory{T1,T2,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,TType>')[T2](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,TType>.T2')[,](IFactory{T1,T2,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,TType>')[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[TType](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,TType>.TType')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[Emik.Unions.Tagged.Fault&lt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[TType](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,TType>.TType')[&gt;](Fault{T}.md 'Emik.Unions.Tagged.Fault<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[&gt;](IFactory{T1,T2,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,TType>'), [Emik.Unions.Tagged.IProduct&lt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T1](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,TType>.T1')[,](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[T2](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,TType>.T2')[&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>'), [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Tagged.Product&lt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[T1](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,TType>.T1')[,](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[T2](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,TType>.T2')[,](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[TType](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,TType>.TType')[&gt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Product()](Product{T1,T2,TType}..ctor.md 'Emik.Unions.Tagged.Product<T1,T2,TType>.Product()') | Initializes a new instance of the [Product&lt;T1,T2,TType&gt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>') class. |
| [Product(bool, bool, bool, bool, string, string, string, string)](Product{T1,T2,TType}..ctor(Boolean,Boolean,Boolean,Boolean,String,String,String,String).md 'Emik.Unions.Tagged.Product<T1,T2,TType>.Product(bool, bool, bool, bool, string, string, string, string)') | Initializes a new instance of the [Product&lt;T1,T2,TType&gt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>') class. |
| [Product(Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, string, string, string, string)](Product{T1,T2,TType}..ctor(Predicate{TType},Predicate{TType},Predicate{TType},Predicate{TType},String,String,String,String).md 'Emik.Unions.Tagged.Product<T1,T2,TType>.Product(System.Predicate<TType>, System.Predicate<TType>, System.Predicate<TType>, System.Predicate<TType>, string, string, string, string)') | Initializes a new instance of the [Product&lt;T1,T2,TType&gt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>') class. |

| Properties | |
| :--- | :--- |
| [this[int]](Product{T1,T2,TType}.Item(Int32).md 'Emik.Unions.Tagged.Product<T1,T2,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |
| [this[string]](Product{T1,T2,TType}.Item(String).md 'Emik.Unions.Tagged.Product<T1,T2,TType>.this[string]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name. |
| [this[PropertyInfo]](Product{T1,T2,TType}.Item(PropertyInfo).md 'Emik.Unions.Tagged.Product<T1,T2,TType>.this[System.Reflection.PropertyInfo]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property. |

| Methods | |
| :--- | :--- |
| [New(T1, T2)](Product{T1,T2,TType}.New(T1,T2).md 'Emik.Unions.Tagged.Product<T1,T2,TType>.New(T1, T2)') | Attempts to create a new instance of [TType](Product{T1,T2,TType}.md#Emik.Unions.Tagged.Product_T1,T2,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,TType>.TType'). |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.IProperties.Properties](Product{T1,T2,TType}.Emik.Unions.IProperties.Properties.md 'Emik.Unions.Tagged.Product<T1,T2,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
| [Emik.Unions.IPropertyEnumerable.Enumeration()](Product{T1,T2,TType}.Emik.Unions.IPropertyEnumerable.Enumeration.md 'Emik.Unions.Tagged.Product<T1,T2,TType>.Emik.Unions.IPropertyEnumerable.Enumeration()') | Enumerates through a [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable')'s values. |
