#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings').[Functor&lt;T,TResult,TType&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')

## Functor<T,TResult,TType>.Then<TFunctor>() Method

Maps this instance to another functor.

```csharp
public virtual TFunctor Then<TFunctor>()
    where TFunctor : Emik.Unions.Mappings.Functor<TFunctor>, Emik.Unions.Mappings.IFunctor<TType, TFunctor>;
```
#### Type parameters

<a name='Emik.Unions.Mappings.Functor_T,TResult,TType_.Then_TFunctor_().TFunctor'></a>

`TFunctor`

The resulting value.

#### Returns
[TFunctor](Functor{T,TResult,TType}.Then{TFunctor}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.Then_TFunctor_().TFunctor 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Then<TFunctor>().TFunctor')  
The instance of [TFunctor](Functor{T,TResult,TType}.Then{TFunctor}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.Then_TFunctor_().TFunctor 'Emik.Unions.Mappings.Functor<T,TResult,TType>.Then<TFunctor>().TFunctor') from the mapping of [TType](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TType 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TType').