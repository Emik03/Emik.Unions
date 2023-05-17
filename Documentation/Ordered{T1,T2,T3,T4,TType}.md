#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints')

## Ordered<T1,T2,T3,T4,TType> Class

Defines an inheritable record that automates logic for a disjoint union.

```csharp
public abstract class Ordered<T1,T2,T3,T4,TType> :
System.Numerics.IEqualityOperators<Emik.Unions.Disjoints.Ordered<T1, T2, T3, T4, TType>, Emik.Unions.Disjoints.Ordered<T1, T2, T3, T4, TType>, bool>,
Emik.Unions.Disjoints.IFactories<T1, T2, T3, T4, TType>,
Emik.Unions.Disjoints.IEither<T1, T2, T3, T4>,
Emik.Unions.Disjoints.IEither,
Emik.Unions.IProperties,
System.IEquatable<Emik.Unions.Disjoints.Ordered<T1, T2, T3, T4, TType>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where TType : Emik.Unions.Disjoints.Ordered<T1, T2, T3, T4, TType>, new()
```
#### Type parameters

<a name='Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T1'></a>

`T1`

The first type of the disjoint union.

<a name='Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T2'></a>

`T2`

The second type of the disjoint union.

<a name='Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T3'></a>

`T3`

The third type of the disjoint union.

<a name='Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4'></a>

`T4`

The fourth type of the disjoint union.

<a name='Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Ordered<T1,T2,T3,T4,TType>

Implements [System.Numerics.IEqualityOperators&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Disjoints.Ordered&lt;](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T1](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T1')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T2](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T2')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T3](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T3')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[TType](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.TType')[&gt;](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Disjoints.Ordered&lt;](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T1](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T1')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T2](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T2')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T3](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T3')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[TType](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.TType')[&gt;](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3'), [Emik.Unions.Disjoints.IFactories&lt;](IFactories{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,T4,TType>')[T1](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T1')[,](IFactories{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,T4,TType>')[T2](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T2')[,](IFactories{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,T4,TType>')[T3](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T3')[,](IFactories{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,T4,TType>')[T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4')[,](IFactories{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,T4,TType>')[TType](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.TType')[&gt;](IFactories{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,T4,TType>'), [Emik.Unions.Disjoints.IEither&lt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T1](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T1')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T2](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T2')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T3](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T3')[,](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>')[T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4')[&gt;](IEither{T1,T2,T3,T4}.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4>'), [IEither](IEither.md 'Emik.Unions.Disjoints.IEither'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Disjoints.Ordered&lt;](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T1](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T1')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T2](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T2')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T3](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T3')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4')[,](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[TType](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.TType')[&gt;](Ordered{T1,T2,T3,T4,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Properties | |
| :--- | :--- |
| [First](Ordered{T1,T2,T3,T4,TType}.First.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.First') | Gets the [T1](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T1 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T1') first value of the disjoint union. |
| [Fourth](Ordered{T1,T2,T3,T4,TType}.Fourth.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.Fourth') | Gets the [T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4') fourth value of the disjoint union. |
| [Index](Ordered{T1,T2,T3,T4,TType}.Index.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.Index') | Gets the index where the value is contained. |
| [Second](Ordered{T1,T2,T3,T4,TType}.Second.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.Second') | Gets the [T2](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T2 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T2') second value of the disjoint union. |
| [Third](Ordered{T1,T2,T3,T4,TType}.Third.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.Third') | Gets the [T3](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T3 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T3') third value of the disjoint union. |
| [this[int]](Ordered{T1,T2,T3,T4,TType}.Item(int).md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |
| [Value](Ordered{T1,T2,T3,T4,TType}.Value.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.Value') | Gets the value. |

| Methods | |
| :--- | :--- |
| [New(T1)](Ordered{T1,T2,T3,T4,TType}.New(T1).md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.New(T1)') | Creates a new instance of [TType](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.TType') with<br/>the [T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4') value being set. |
| [New(T2)](Ordered{T1,T2,T3,T4,TType}.New(T2).md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.New(T2)') | Creates a new instance of [TType](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.TType') with<br/>the [T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4') value being set. |
| [New(T3)](Ordered{T1,T2,T3,T4,TType}.New(T3).md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.New(T3)') | Creates a new instance of [TType](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.TType') with<br/>the [T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4') value being set. |
| [New(T4)](Ordered{T1,T2,T3,T4,TType}.New(T4).md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.New(T4)') | Creates a new instance of [TType](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.TType') with<br/>the [T4](Ordered{T1,T2,T3,T4,TType}.md#Emik.Unions.Disjoints.Ordered_T1,T2,T3,T4,TType_.T4 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.T4') value being set. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.IProperties.Properties](Ordered{T1,T2,T3,T4,TType}.Emik.Unions.IProperties.Properties.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,T4,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
