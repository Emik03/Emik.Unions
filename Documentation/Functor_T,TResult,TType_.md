#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings')

## Functor<T,TResult,TType> Class

Defines a type that acts as a functor and `newtype` idiom from Rust simultaneously.

```csharp
public abstract class Functor<T,TResult,TType> : Emik.Unions.Mappings.Functor<TType>,
Emik.Unions.Mappings.IFunctor<T, TType>,
Emik.Unions.Tagged.IProduct<TResult, System.Converter<T, TResult>>,
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties,
System.IEquatable<Emik.Unions.Mappings.Functor<T, TResult, TType>>
    where TType : Emik.Unions.Mappings.Functor<T, TResult, TType>
```
#### Type parameters

<a name='Emik.Unions.Mappings.Functor_T,TResult,TType_.T'></a>

`T`

The type that can be converted into this type.

<a name='Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult'></a>

`TResult`

The resulting type that encapsulates this type.

<a name='Emik.Unions.Mappings.Functor_T,TResult,TType_.TType'></a>

`TType`

The type of the implementor.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Emik.Unions.Mappings.Functor&lt;](Functor_TType_.md 'Emik.Unions.Mappings.Functor<TType>')[TType](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType')[&gt;](Functor_TType_.md 'Emik.Unions.Mappings.Functor<TType>') &#129106; Functor<T,TResult,TType>

Derived  
&#8627; [Self&lt;T&gt;](Self_T_.md 'Emik.Unions.Mappings.Self<T>')

Implements [Emik.Unions.Mappings.IFunctor&lt;](IFunctor_T,TType_.md 'Emik.Unions.Mappings.IFunctor<T,TType>')[T](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](IFunctor_T,TType_.md 'Emik.Unions.Mappings.IFunctor<T,TType>')[TType](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType')[&gt;](IFunctor_T,TType_.md 'Emik.Unions.Mappings.IFunctor<T,TType>'), [Emik.Unions.Tagged.IProduct&lt;](IProduct_T1,T2_.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[TResult](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[,](IProduct_T1,T2_.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[&gt;](IProduct_T1,T2_.md 'Emik.Unions.Tagged.IProduct<T1,T2>'), [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Mappings.Functor&lt;](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[T](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[TResult](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[,](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[TType](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType')[&gt;](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Functor(Converter&lt;T,TResult&gt;)](Functor_T,TResult,TType_..ctor(Converter).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Functor(System.Converter<T,TResult>)') | Defines a type that acts as a functor and `newtype` idiom from Rust simultaneously. |

| Properties | |
| :--- | :--- |
| [Converter](Functor_T,TResult,TType_.Converter().md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Converter') | The converting function that creates this instance, much like `From` in Rust. |
| [Factory](Functor_T,TResult,TType_.Factory().md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Factory') | Gets the factory that creates a [TType](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType') out of [T](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T'). |
| [New](Functor_T,TResult,TType_.New().md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.New') | Gets or sets the method used to create an instance of [TType](Functor_T,TResult,TType_.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType') without parameters.<br/>This is meant to be set in a static constructor to intercept the creation of [Instance](Functor_TType_.Instance().md 'Emik.Unions.Mappings.Functor<TType>.Instance'). |
| [this[int]](Functor_T,TResult,TType_.Item(Int32).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |
| [this[string]](Functor_T,TResult,TType_.Item(String).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.this[string]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name. |
| [this[PropertyInfo]](Functor_T,TResult,TType_.Item(PropertyInfo).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.this[System.Reflection.PropertyInfo]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property. |

| Methods | |
| :--- | :--- |
| [Then&lt;TFunctor&gt;()](Functor_T,TResult,TType_.Then().md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Then<TFunctor>()') | Maps this instance to another functor. |
| [To&lt;TFunctor&gt;()](Functor_T,TResult,TType_.To().md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.To<TFunctor>()') | Maps this instance to another functor. |

| Operators | |
| :--- | :--- |
| [implicit operator TResult(Functor&lt;T,TResult,TType&gt;)](Functor_T,TResult,TType_.op_Implicit(Functor).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.op_Implicit TResult(Emik.Unions.Mappings.Functor<T,TResult,TType>)') | Gets the encapsulated value. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.IProperties.Properties](Functor_T,TResult,TType_.Emik.Unions.IProperties.Properties().md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
| [Emik.Unions.IPropertyEnumerable.Enumeration()](Functor_T,TResult,TType_.Emik.Unions.IPropertyEnumerable.Enumeration().md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Emik.Unions.IPropertyEnumerable.Enumeration()') | Enumerates through a [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable')'s values. |
