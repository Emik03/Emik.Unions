#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints')

## IEither<T1,T2,T3> Interface

Defines an interface for disjoint union of size 3.

```csharp
public interface IEither<out T1,out T2,out T3> :
Emik.Unions.Disjoints.IEither,
Emik.Unions.IProperties
```
#### Type parameters

<a name='Emik.Unions.Disjoints.IEither_T1,T2,T3_.T1'></a>

`T1`

The first type of the disjoint union.

<a name='Emik.Unions.Disjoints.IEither_T1,T2,T3_.T2'></a>

`T2`

The second type of the disjoint union.

<a name='Emik.Unions.Disjoints.IEither_T1,T2,T3_.T3'></a>

`T3`

The third type of the disjoint union.

Derived  
&#8627; [Either&lt;T1,T2,T3,TType&gt;](Either_T1,T2,T3,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,TType>')

Implements [IEither](IEither.md 'Emik.Unions.Disjoints.IEither'), [IProperties](IProperties.md 'Emik.Unions.IProperties')

| Properties | |
| :--- | :--- |
| [First](IEither_T1,T2,T3_.First.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.First') | Gets the [T1](IEither_T1,T2,T3_.md#Emik.Unions.Disjoints.IEither_T1,T2,T3_.T1 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.T1') first value of the disjoint union. |
| [Second](IEither_T1,T2,T3_.Second.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.Second') | Gets the [T2](IEither_T1,T2,T3_.md#Emik.Unions.Disjoints.IEither_T1,T2,T3_.T2 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.T2') second value of the disjoint union. |
| [Third](IEither_T1,T2,T3_.Third.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.Third') | Gets the [T3](IEither_T1,T2,T3_.md#Emik.Unions.Disjoints.IEither_T1,T2,T3_.T3 'Emik.Unions.Disjoints.IEither<T1,T2,T3>.T3') third value of the disjoint union. |
