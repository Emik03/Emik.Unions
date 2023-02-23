#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## Product<T1,T2,T3,T4,TType> Class

Defines an inheritable record that automates logic for a union.

```csharp
public abstract class Product<T1,T2,T3,T4,TType> :
Emik.Unions.Tagged.IProduct<T1, T2, T3, T4>,
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties,
System.IEquatable<Emik.Unions.Tagged.Product<T1, T2, T3, T4, TType>>
    where TType : Emik.Unions.Tagged.Product<T1, T2, T3, T4, TType>
```
#### Type parameters

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T1'></a>

`T1`

The first type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T2'></a>

`T2`

The second type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T3'></a>

`T3`

The third type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T4'></a>

`T4`

The fourth type of the union.

<a name='Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Product<T1,T2,T3,T4,TType>

Implements [Emik.Unions.Tagged.IProduct&lt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')[T1](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T1')[,](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')[T2](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T2')[,](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')[T3](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T3')[,](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')[T4](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T4')[&gt;](IProduct_T1,T2,T3,T4_.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>'), [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Tagged.Product&lt;](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')[T1](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T1')[,](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')[T2](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T2')[,](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')[T3](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T3')[,](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')[T4](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.T4')[,](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')[TType](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.TType')[&gt;](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Product()](Product_T1,T2,T3,T4,TType_.Product().md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.Product()') | Initializes a new instance of the [Product&lt;T1,T2,T3,T4,TType&gt;](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>') class. |
| [Product(bool, bool, bool, bool, string, string, string, string)](Product_T1,T2,T3,T4,TType_..ctor.Hfv1cIx3ud9d++VAfBF+Fg.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.Product(bool, bool, bool, bool, string, string, string, string)') | Initializes a new instance of the [Product&lt;T1,T2,T3,T4,TType&gt;](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>') class. |
| [Product(Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, Predicate&lt;TType&gt;, string, string, string, string)](Product_T1,T2,T3,T4,TType_..ctor.ChIcQ3N8CRp8kPu73mKdlw.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.Product(System.Predicate<TType>, System.Predicate<TType>, System.Predicate<TType>, System.Predicate<TType>, string, string, string, string)') | Initializes a new instance of the [Product&lt;T1,T2,T3,T4,TType&gt;](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>') class. |

| Properties | |
| :--- | :--- |
| [this[int]](Product_T1,T2,T3,T4,TType_.Item.NoMa1o5u+KmVsWbEDaq9hg.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |
| [this[string]](Product_T1,T2,T3,T4,TType_.Item.4KtBHx94YizrRkLC0Ie71Q.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.this[string]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name. |
| [this[PropertyInfo]](Product_T1,T2,T3,T4,TType_.Item.P8u4bxtJ/eDiDZrFga3mSg.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.this[System.Reflection.PropertyInfo]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property. |

| Methods | |
| :--- | :--- |
| [New(T1, T2, T3, T4)](Product_T1,T2,T3,T4,TType_.New.enmKRcQC9TBcftHtV5cpwA.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.New(T1, T2, T3, T4)') | Attempts to create a new instance of [TType](Product_T1,T2,T3,T4,TType_.md#Emik.Unions.Tagged.Product_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.TType'). |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.IProperties.Properties](Product_T1,T2,T3,T4,TType_.Emik.Unions.IProperties.Properties.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
| [Emik.Unions.IPropertyEnumerable.Enumeration()](Product_T1,T2,T3,T4,TType_.Emik.Unions.IPropertyEnumerable.Enumeration().md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>.Emik.Unions.IPropertyEnumerable.Enumeration()') | Enumerates through a [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable')'s values. |
