#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints')

## Overload<T1,T2,T3> Class

Defines a disjoint union with implicit conversions, for parameter signatures.

```csharp
public sealed class Overload<T1,T2,T3> : Emik.Unions.Disjoints.Either<T1, T2, T3, Emik.Unions.Disjoints.Overload<T1, T2, T3>>,
System.Numerics.IEqualityOperators<Emik.Unions.Disjoints.Overload<T1, T2, T3>, Emik.Unions.Disjoints.Overload<T1, T2, T3>, bool>,
System.IEquatable<Emik.Unions.Disjoints.Overload<T1, T2, T3>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
```
#### Type parameters

<a name='Emik.Unions.Disjoints.Overload_T1,T2,T3_.T1'></a>

`T1`

The first type of the disjoint union.

<a name='Emik.Unions.Disjoints.Overload_T1,T2,T3_.T2'></a>

`T2`

The second type of the disjoint union.

<a name='Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3'></a>

`T3`

The third type of the disjoint union.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Emik.Unions.Disjoints.Either&lt;](Either{T1,T2,T3,TType}.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,TType>')[T1](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T1 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T1')[,](Either{T1,T2,T3,TType}.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,TType>')[T2](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T2 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T2')[,](Either{T1,T2,T3,TType}.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,TType>')[T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3')[,](Either{T1,T2,T3,TType}.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,TType>')[Emik.Unions.Disjoints.Overload&lt;](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T1](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T1 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T1')[,](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T2](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T2 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T2')[,](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3')[&gt;](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[&gt;](Either{T1,T2,T3,TType}.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,TType>') &#129106; Overload<T1,T2,T3>

Implements [System.Numerics.IEqualityOperators&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Disjoints.Overload&lt;](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T1](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T1 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T1')[,](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T2](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T2 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T2')[,](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3')[&gt;](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Disjoints.Overload&lt;](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T1](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T1 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T1')[,](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T2](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T2 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T2')[,](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3')[&gt;](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Disjoints.Overload&lt;](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T1](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T1 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T1')[,](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T2](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T2 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T2')[,](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3')[&gt;](Overload{T1,T2,T3}.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Overload(T1, T2, T3)](Overload{T1,T2,T3}..ctor(T1,T2,T3).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.Overload(T1, T2, T3)') | Defines a disjoint union with implicit conversions, for parameter signatures. |
| [Overload(T1)](Overload{T1,T2,T3}..ctor(T1).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.Overload(T1)') | Creates a new instance of TType with<br/>the [T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3') value being set. |
| [Overload(T2)](Overload{T1,T2,T3}..ctor(T2).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.Overload(T2)') | Creates a new instance of TType with<br/>the [T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3') value being set. |
| [Overload(T3)](Overload{T1,T2,T3}..ctor(T3).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.Overload(T3)') | Creates a new instance of TType with<br/>the [T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3') value being set. |

| Properties | |
| :--- | :--- |
| [First](Overload{T1,T2,T3}.First.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.First') | The first value of the disjoint union. |
| [Second](Overload{T1,T2,T3}.Second.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.Second') | The second value of the disjoint union. |
| [Third](Overload{T1,T2,T3}.Third.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.Third') | The third value of the disjoint union. |

| Operators | |
| :--- | :--- |
| [explicit operator T1(Overload&lt;T1,T2,T3&gt;)](Overload{T1,T2,T3}.T1(Overload{T1,T2,T3}).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.op_Explicit T1(Emik.Unions.Disjoints.Overload<T1,T2,T3>)') | Gets the [T1](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T1 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T1') first value of the disjoint union. |
| [explicit operator T2(Overload&lt;T1,T2,T3&gt;)](Overload{T1,T2,T3}.T2(Overload{T1,T2,T3}).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.op_Explicit T2(Emik.Unions.Disjoints.Overload<T1,T2,T3>)') | Gets the [T2](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T2 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T2') second value of the disjoint union. |
| [explicit operator T3(Overload&lt;T1,T2,T3&gt;)](Overload{T1,T2,T3}.T3(Overload{T1,T2,T3}).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.op_Explicit T3(Emik.Unions.Disjoints.Overload<T1,T2,T3>)') | Gets the [T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3') third value of the disjoint union. |
| [implicit operator Overload&lt;T1,T2,T3&gt;(T1)](Overload{T1,T2,T3}.Overload(T1).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.op_Implicit Emik.Unions.Disjoints.Overload<T1,T2,T3>(T1)') | Creates a new instance of TType with<br/>the [T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3') value being set. |
| [implicit operator Overload&lt;T1,T2,T3&gt;(T2)](Overload{T1,T2,T3}.Overload(T2).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.op_Implicit Emik.Unions.Disjoints.Overload<T1,T2,T3>(T2)') | Creates a new instance of TType with<br/>the [T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3') value being set. |
| [implicit operator Overload&lt;T1,T2,T3&gt;(T3)](Overload{T1,T2,T3}.Overload(T3).md 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.op_Implicit Emik.Unions.Disjoints.Overload<T1,T2,T3>(T3)') | Creates a new instance of TType with<br/>the [T3](Overload{T1,T2,T3}.md#Emik.Unions.Disjoints.Overload_T1,T2,T3_.T3 'Emik.Unions.Disjoints.Overload<T1,T2,T3>.T3') value being set. |
