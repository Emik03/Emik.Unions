#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings')

## IFunctor<T,TType> Interface

A functor with an unspecified result type to allow for better type inference.  
Currently used in [To&lt;TFunctor&gt;()](Functor_T,TResult,TType_.To_TFunctor_().md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.To<TFunctor>()').

```csharp
public interface IFunctor<T,TType>
    where TType : Emik.Unions.Mappings.IFunctor<T, TType>
```
#### Type parameters

<a name='Emik.Unions.Mappings.IFunctor_T,TType_.T'></a>

`T`

The input type.

<a name='Emik.Unions.Mappings.IFunctor_T,TType_.TType'></a>

`TType`

The type of the implementor.

Derived  
&#8627; [Functor&lt;T,TResult,TType&gt;](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')

| Properties | |
| :--- | :--- |
| [Factory](IFunctor_T,TType_.Factory.md 'Emik.Unions.Mappings.IFunctor<T,TType>.Factory') | Gets the factory that creates a [TType](IFunctor_T,TType_.md#Emik.Unions.Mappings.IFunctor_T,TType_.TType 'Emik.Unions.Mappings.IFunctor<T,TType>.TType') out of [T](IFunctor_T,TType_.md#Emik.Unions.Mappings.IFunctor_T,TType_.T 'Emik.Unions.Mappings.IFunctor<T,TType>.T'). |
