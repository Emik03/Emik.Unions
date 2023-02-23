#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## Product<T1,TType> Class

Defines an inheritable record that automates logic for a union.

```csharp
public abstract class Product<T1,TType> :
Emik.Unions.Tagged.IProduct<T1>,
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties,
System.IEquatable<Emik.Unions.Tagged.Product<T1, TType>>
    where TType : Emik.Unions.Tagged.Product<T1, TType>
```
#### Type parameters

<a name='Emik.Unions.Tagged.Product_T1,TType_.T1'></a>

`T1`

The first type of the union.

<a name='Emik.Unions.Tagged.Product_T1,TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Product<T1,TType>

Implements [Emik.Unions.Tagged.IProduct&lt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>')[T1](Product_T1,TType_.md#Emik.Unions.Tagged.Product_T1,TType_.T1 'Emik.Unions.Tagged.Product<T1,TType>.T1')[&gt;](IProduct_T1_.md 'Emik.Unions.Tagged.IProduct<T1>'), [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Tagged.Product&lt;](Product_T1,TType_.md 'Emik.Unions.Tagged.Product<T1,TType>')[T1](Product_T1,TType_.md#Emik.Unions.Tagged.Product_T1,TType_.T1 'Emik.Unions.Tagged.Product<T1,TType>.T1')[,](Product_T1,TType_.md 'Emik.Unions.Tagged.Product<T1,TType>')[TType](Product_T1,TType_.md#Emik.Unions.Tagged.Product_T1,TType_.TType 'Emik.Unions.Tagged.Product<T1,TType>.TType')[&gt;](Product_T1,TType_.md 'Emik.Unions.Tagged.Product<T1,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Product()](Product_T1,TType_.Product().md 'Emik.Unions.Tagged.Product<T1,TType>.Product()') | Initializes a new instance of the [Product&lt;T1,TType&gt;](Product_T1,TType_.md 'Emik.Unions.Tagged.Product<T1,TType>') class. |
| [Product(bool, bool, bool, bool, string, string, string, string)](Product_T1,TType_..ctor.gtk/j0EpoZh5MvepHN6DIQ.md 'Emik.Unions.Tagged.Product<T1,TType>.Product(bool, bool, bool, bool, string, string, string, string)') | Initializes a new instance of the [Product&lt;T1,TType&gt;](Product_T1,TType_.md 'Emik.Unions.Tagged.Product<T1,TType>') class. |
| [Product(Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, string, string, string, string)](Product_T1,TType_..ctor.BwRWKsuIbqOg+EZbjw32qA.md 'Emik.Unions.Tagged.Product<T1,TType>.Product(System.Predicate<TType>, System.Predicate<TType>, System.Predicate<TType>, System.Predicate<TType>, string, string, string, string)') | Initializes a new instance of the [Product&lt;T1,TType&gt;](Product_T1,TType_.md 'Emik.Unions.Tagged.Product<T1,TType>') class. |

| Properties | |
| :--- | :--- |
| [this[int]](Product_T1,TType_.Item.wK2HLKd8bmYRQJx9KLgTWw.md 'Emik.Unions.Tagged.Product<T1,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |
| [this[string]](Product_T1,TType_.Item.liI5SL0ikdauGJGZzbn3xw.md 'Emik.Unions.Tagged.Product<T1,TType>.this[string]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name. |
| [this[PropertyInfo]](Product_T1,TType_.Item.dHIQ+M/Ve152OfeWUaL/bA.md 'Emik.Unions.Tagged.Product<T1,TType>.this[System.Reflection.PropertyInfo]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property. |

| Methods | |
| :--- | :--- |
| [New(T1)](Product_T1,TType_.New.aRdXajreGi3uUBuQ8SVZBQ.md 'Emik.Unions.Tagged.Product<T1,TType>.New(T1)') | Attempts to create a new instance of [TType](Product_T1,TType_.md#Emik.Unions.Tagged.Product_T1,TType_.TType 'Emik.Unions.Tagged.Product<T1,TType>.TType'). |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.IProperties.Properties](Product_T1,TType_.Emik.Unions.IProperties.Properties.md 'Emik.Unions.Tagged.Product<T1,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
| [Emik.Unions.IPropertyEnumerable.Enumeration()](Product_T1,TType_.Emik.Unions.IPropertyEnumerable.Enumeration().md 'Emik.Unions.Tagged.Product<T1,TType>.Emik.Unions.IPropertyEnumerable.Enumeration()') | Enumerates through a [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable')'s values. |
