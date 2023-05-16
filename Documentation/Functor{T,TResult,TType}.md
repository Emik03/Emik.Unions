#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings')

## Functor<T,TResult,TType> Class

Defines a type that acts as a functor and `newtype` idiom from Rust simultaneously.

```csharp
public abstract class Functor<T,TResult,TType> : Emik.Unions.Mappings.Functor<TType>,
System.Numerics.IEqualityOperators<Emik.Unions.Mappings.Functor<T, TResult, TType>, Emik.Unions.Mappings.Functor<T, TResult, TType>, bool>,
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

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Emik.Unions.Mappings.Functor&lt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>')[TType](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType')[&gt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>') &#129106; Functor<T,TResult,TType>

Derived  
&#8627; [Self&lt;T&gt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')

Implements [System.Numerics.IEqualityOperators&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Mappings.Functor&lt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[T](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[TResult](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[,](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[TType](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType')[&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Mappings.Functor&lt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[T](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[TResult](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[,](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[TType](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType')[&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3'), [Emik.Unions.Mappings.IFunctor&lt;](IFunctor{T,TType}.md 'Emik.Unions.Mappings.IFunctor<T,TType>')[T](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](IFunctor{T,TType}.md 'Emik.Unions.Mappings.IFunctor<T,TType>')[TType](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType')[&gt;](IFunctor{T,TType}.md 'Emik.Unions.Mappings.IFunctor<T,TType>'), [Emik.Unions.Tagged.IProduct&lt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[TResult](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[,](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')[System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>'), [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Mappings.Functor&lt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[T](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[TResult](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[,](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[TType](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType')[&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Functor(Converter&lt;T,TResult&gt;)](Functor{T,TResult,TType}..ctor(Converter{T,TResult}).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Functor(System.Converter<T,TResult>)') | Defines a type that acts as a functor and `newtype` idiom from Rust simultaneously. |

| Properties | |
| :--- | :--- |
| [Converter](Functor{T,TResult,TType}.Converter.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Converter') | The converting function that creates this instance, much like `From` in Rust. |
| [Factory](Functor{T,TResult,TType}.Factory.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Factory') | Gets the factory that creates a [TType](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType') out of [T](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T'). |
| [New](Functor{T,TResult,TType}.New.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.New') | Gets or sets the method used to create an instance of [TType](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType') without parameters.<br/>This is meant to be set in a static constructor to intercept the creation of [Instance](Functor{TType}.Instance.md 'Emik.Unions.Mappings.Functor<TType>.Instance'). |
| [this[int]](Functor{T,TResult,TType}.Item(Int32).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |
| [this[string]](Functor{T,TResult,TType}.Item(String).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.this[string]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name. |
| [this[PropertyInfo]](Functor{T,TResult,TType}.Item(PropertyInfo).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.this[System.Reflection.PropertyInfo]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property. |

| Methods | |
| :--- | :--- |
| [Then&lt;TFunctor&gt;()](Functor{T,TResult,TType}.Then{TFunctor}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Then<TFunctor>()') | Maps this instance to another functor. |
| [To&lt;TFunctor&gt;()](Functor{T,TResult,TType}.To{TFunctor}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.To<TFunctor>()') | Maps this instance to another functor. |

| Operators | |
| :--- | :--- |
| [implicit operator TResult(Functor&lt;T,TResult,TType&gt;)](Functor{T,TResult,TType}.TResult(Functor{T,TResult,TType}).md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.op_Implicit TResult(Emik.Unions.Mappings.Functor<T,TResult,TType>)') | Gets the encapsulated value. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.IProperties.Properties](Functor{T,TResult,TType}.Emik.Unions.IProperties.Properties.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
| [Emik.Unions.IPropertyEnumerable.Enumeration()](Functor{T,TResult,TType}.Emik.Unions.IPropertyEnumerable.Enumeration.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Emik.Unions.IPropertyEnumerable.Enumeration()') | Enumerates through a [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable')'s values. |
