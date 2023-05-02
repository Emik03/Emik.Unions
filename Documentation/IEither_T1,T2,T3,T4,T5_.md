#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints')

## IEither<T1,T2,T3,T4,T5> Interface

Defines an interface for disjoint union of size 5.

```csharp
public interface IEither<out T1,out T2,out T3,out T4,out T5> :
Emik.Unions.Disjoints.IEither,
Emik.Unions.IProperties
```
#### Type parameters

<a name='Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T1'></a>

`T1`

The first type of the disjoint union.

<a name='Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T2'></a>

`T2`

The second type of the disjoint union.

<a name='Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T3'></a>

`T3`

The third type of the disjoint union.

<a name='Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T4'></a>

`T4`

The fourth type of the disjoint union.

<a name='Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T5'></a>

`T5`

The fifth type of the disjoint union.

Derived  
&#8627; [Either&lt;T1,T2,T3,T4,T5,TType&gt;](Either_T1,T2,T3,T4,T5,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>')

Implements [IEither](IEither.md 'Emik.Unions.Disjoints.IEither'), [IProperties](IProperties.md 'Emik.Unions.IProperties')

| Properties | |
| :--- | :--- |
| [Fifth](IEither_T1,T2,T3,T4,T5_.Fifth().md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.Fifth') | Gets the [T5](IEither_T1,T2,T3,T4,T5_.md#Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T5 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.T5') fifth value of the disjoint union. |
| [First](IEither_T1,T2,T3,T4,T5_.First().md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.First') | Gets the [T1](IEither_T1,T2,T3,T4,T5_.md#Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T1 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.T1') first value of the disjoint union. |
| [Fourth](IEither_T1,T2,T3,T4,T5_.Fourth().md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.Fourth') | Gets the [T4](IEither_T1,T2,T3,T4,T5_.md#Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T4 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.T4') fourth value of the disjoint union. |
| [Second](IEither_T1,T2,T3,T4,T5_.Second().md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.Second') | Gets the [T2](IEither_T1,T2,T3,T4,T5_.md#Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T2 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.T2') second value of the disjoint union. |
| [Third](IEither_T1,T2,T3,T4,T5_.Third().md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.Third') | Gets the [T3](IEither_T1,T2,T3,T4,T5_.md#Emik.Unions.Disjoints.IEither_T1,T2,T3,T4,T5_.T3 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>.T3') third value of the disjoint union. |
