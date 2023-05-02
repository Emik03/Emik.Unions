#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## IProduct<T1,T2,T3,T4> Interface

Defines an interface for union of size 4.

```csharp
public interface IProduct<out T1,out T2,out T3,out T4> :
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties
```
#### Type parameters

<a name='Emik.Unions.Tagged.IProduct_T1,T2,T3,T4_.T1'></a>

`T1`

The first type of the union.

<a name='Emik.Unions.Tagged.IProduct_T1,T2,T3,T4_.T2'></a>

`T2`

The second type of the union.

<a name='Emik.Unions.Tagged.IProduct_T1,T2,T3,T4_.T3'></a>

`T3`

The third type of the union.

<a name='Emik.Unions.Tagged.IProduct_T1,T2,T3,T4_.T4'></a>

`T4`

The fourth type of the union.

Derived  
&#8627; [Product&lt;T1,T2,T3,T4,TType&gt;](Product_T1,T2,T3,T4,TType_.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')

Implements [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties')

| Properties | |
| :--- | :--- |
| [First](IProduct_T1,T2,T3,T4_.First().md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>.First') | Gets the [T1](IProduct_T1,T2,T3,T4_.md#Emik.Unions.Tagged.IProduct_T1,T2,T3,T4_.T1 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>.T1') first value of the union. |
| [Fourth](IProduct_T1,T2,T3,T4_.Fourth().md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>.Fourth') | Gets the [T4](IProduct_T1,T2,T3,T4_.md#Emik.Unions.Tagged.IProduct_T1,T2,T3,T4_.T4 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>.T4') fourth value of the union. |
| [Second](IProduct_T1,T2,T3,T4_.Second().md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>.Second') | Gets the [T2](IProduct_T1,T2,T3,T4_.md#Emik.Unions.Tagged.IProduct_T1,T2,T3,T4_.T2 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>.T2') second value of the union. |
| [Third](IProduct_T1,T2,T3,T4_.Third().md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>.Third') | Gets the [T3](IProduct_T1,T2,T3,T4_.md#Emik.Unions.Tagged.IProduct_T1,T2,T3,T4_.T3 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>.T3') third value of the union. |
