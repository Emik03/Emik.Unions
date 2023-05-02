#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## IProduct<T1,T2> Interface

Defines an interface for union of size 2.

```csharp
public interface IProduct<out T1,out T2> :
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties
```
#### Type parameters

<a name='Emik.Unions.Tagged.IProduct_T1,T2_.T1'></a>

`T1`

The first type of the union.

<a name='Emik.Unions.Tagged.IProduct_T1,T2_.T2'></a>

`T2`

The second type of the union.

Derived  
&#8627; [Functor&lt;T,TResult,TType&gt;](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')  
&#8627; [Product&lt;T1,T2,TType&gt;](Product_T1,T2,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')

Implements [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties')

| Properties | |
| :--- | :--- |
| [First](IProduct_T1,T2_.First().md 'Emik.Unions.Tagged.IProduct<T1,T2>.First') | Gets the [T1](IProduct_T1,T2_.md#Emik.Unions.Tagged.IProduct_T1,T2_.T1 'Emik.Unions.Tagged.IProduct<T1,T2>.T1') first value of the union. |
| [Second](IProduct_T1,T2_.Second().md 'Emik.Unions.Tagged.IProduct<T1,T2>.Second') | Gets the [T2](IProduct_T1,T2_.md#Emik.Unions.Tagged.IProduct_T1,T2_.T2 'Emik.Unions.Tagged.IProduct<T1,T2>.T2') second value of the union. |
