#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## IProduct<T1> Interface

Defines an interface for union of size 1.

```csharp
public interface IProduct<out T1> :
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties
```
#### Type parameters

<a name='Emik.Unions.Tagged.IProduct_T1_.T1'></a>

`T1`

The first type of the union.

Derived  
&#8627; [Product&lt;T1,TType&gt;](Product_T1,TType_.md 'Emik.Unions.Tagged.Product<T1,TType>')

Implements [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties')

| Properties | |
| :--- | :--- |
| [First](IProduct_T1_.First.md 'Emik.Unions.Tagged.IProduct<T1>.First') | Gets the [T1](IProduct_T1_.md#Emik.Unions.Tagged.IProduct_T1_.T1 'Emik.Unions.Tagged.IProduct<T1>.T1') first value of the union. |
