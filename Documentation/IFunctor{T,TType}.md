#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings')

## IFunctor<T,TType> Interface

A functor with an unspecified result type to allow for better type inference.  
Currently used in [To&lt;TFunctor&gt;()](Functor{T,TResult,TType}.To{TFunctor}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>.To<TFunctor>()').

```csharp
public interface IFunctor<in T,out TType>
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
&#8627; [Functor&lt;T,TResult,TType&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')

| Properties | |
| :--- | :--- |
| [Factory](IFunctor{T,TType}.Factory.md 'Emik.Unions.Mappings.IFunctor<T,TType>.Factory') | Gets the factory that creates a [TType](IFunctor{T,TType}.md#Emik.Unions.Mappings.IFunctor_T,TType_.TType 'Emik.Unions.Mappings.IFunctor<T,TType>.TType') out of [T](IFunctor{T,TType}.md#Emik.Unions.Mappings.IFunctor_T,TType_.T 'Emik.Unions.Mappings.IFunctor<T,TType>.T'). |
