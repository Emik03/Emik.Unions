#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## Product<T1,T2,T3,TType> Class

Defines an inheritable record that automates logic for a union.

```csharp
public abstract class Product<T1,T2,T3,TType> :
Emik.Unions.Tagged.IProduct<T1, T2, T3>,
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties,
System.IEquatable<Emik.Unions.Tagged.Product<T1, T2, T3, TType>>
    where TType : Emik.Unions.Tagged.Product<T1, T2, T3, TType>
```
#### Type parameters

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T1'></a>

`T1`

The first type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T2'></a>

`T2`

The second type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T3'></a>

`T3`

The third type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Product<T1,T2,T3,TType>

Implements [Emik.Unions.Tagged.IProduct&lt;](IProduct_T1,T2,T3_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3>')[T1](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T1')[,](IProduct_T1,T2,T3_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3>')[T2](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T2')[,](IProduct_T1,T2,T3_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3>')[T3](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T3 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T3')[&gt;](IProduct_T1,T2,T3_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3>'), [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Tagged.Product&lt;](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>')[T1](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T1')[,](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>')[T2](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T2')[,](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>')[T3](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.T3 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.T3')[,](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>')[TType](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.TType')[&gt;](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Product()](Product_T1,T2,T3,TType_..ctor().md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.Product()') | Initializes a new instance of the [Product&lt;T1,T2,T3,TType&gt;](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>') class. |
| [Product(bool, bool, bool, bool, string, string, string, string)](Product_T1,T2,T3,TType_..ctor(Boolean,Boolean,Boolean,Boolean,String,String,String,String).md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.Product(bool, bool, bool, bool, string, string, string, string)') | Initializes a new instance of the [Product&lt;T1,T2,T3,TType&gt;](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>') class. |
| [Product(Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, string, string, string, string)](Product_T1,T2,T3,TType_..ctor(Predicate,Predicate,Predicate,Predicate,String,String,String,String).md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.Product(System.Predicate<TType>, System.Predicate<TType>, System.Predicate<TType>, System.Predicate<TType>, string, string, string, string)') | Initializes a new instance of the [Product&lt;T1,T2,T3,TType&gt;](Product_T1,T2,T3,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>') class. |

| Properties | |
| :--- | :--- |
| [this[int]](Product_T1,T2,T3,TType_.Item(Int32).md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |
| [this[string]](Product_T1,T2,T3,TType_.Item(String).md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.this[string]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name. |
| [this[PropertyInfo]](Product_T1,T2,T3,TType_.Item(PropertyInfo).md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.this[System.Reflection.PropertyInfo]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property. |

| Methods | |
| :--- | :--- |
| [New(T1, T2, T3)](Product_T1,T2,T3,TType_.New(T1,T2,T3).md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.New(T1, T2, T3)') | Attempts to create a new instance of [TType](Product_T1,T2,T3,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.TType'). |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.IProperties.Properties](Product_T1,T2,T3,TType_.Emik.Unions.IProperties.Properties().md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
| [Emik.Unions.IPropertyEnumerable.Enumeration()](Product_T1,T2,T3,TType_.Emik.Unions.IPropertyEnumerable.Enumeration().md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>.Emik.Unions.IPropertyEnumerable.Enumeration()') | Enumerates through a [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable')'s values. |
