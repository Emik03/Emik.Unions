#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## IProduct<T1,T2,T3> Interface

Defines an interface for union of size 3.

```csharp
public interface IProduct<out T1,out T2,out T3> :
Emik.Unions.Tagged.IProduct,
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties
```
#### Type parameters

<a name='Emik.Unions.Tagged.IProduct_T1,T2,T3_.T1'></a>

`T1`

The first type of the union.

<a name='Emik.Unions.Tagged.IProduct_T1,T2,T3_.T2'></a>

`T2`

The second type of the union.

<a name='Emik.Unions.Tagged.IProduct_T1,T2,T3_.T3'></a>

`T3`

The third type of the union.

Derived  
&#8627; [Product&lt;T1,T2,T3,TType&gt;](Product{T1,T2,T3,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>')

Implements [IProduct](IProduct.md 'Emik.Unions.Tagged.IProduct'), [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties')

| Properties | |
| :--- | :--- |
| [First](IProduct{T1,T2,T3}.First.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3>.First') | Gets the [T1](IProduct{T1,T2,T3}.md#Emik.Unions.Tagged.IProduct_T1,T2,T3_.T1 'Emik.Unions.Tagged.IProduct<T1,T2,T3>.T1') first value of the union. |
| [Second](IProduct{T1,T2,T3}.Second.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3>.Second') | Gets the [T2](IProduct{T1,T2,T3}.md#Emik.Unions.Tagged.IProduct_T1,T2,T3_.T2 'Emik.Unions.Tagged.IProduct<T1,T2,T3>.T2') second value of the union. |
| [Third](IProduct{T1,T2,T3}.Third.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3>.Third') | Gets the [T3](IProduct{T1,T2,T3}.md#Emik.Unions.Tagged.IProduct_T1,T2,T3_.T3 'Emik.Unions.Tagged.IProduct<T1,T2,T3>.T3') third value of the union. |
