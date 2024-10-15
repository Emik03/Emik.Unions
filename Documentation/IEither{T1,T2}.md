#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints')

## IEither<T1,T2> Interface

Defines an interface for disjoint union of size 2.

```csharp
public interface IEither<out T1,out T2> :
Emik.Unions.Disjoints.IEither,
Emik.Unions.IProperties
    where T1 : notnull
    where T2 : notnull
```
#### Type parameters

<a name='Emik.Unions.Disjoints.IEither_T1,T2_.T1'></a>

`T1`

The first type of the disjoint union.

<a name='Emik.Unions.Disjoints.IEither_T1,T2_.T2'></a>

`T2`

The second type of the disjoint union.

Derived  
&#8627; [Either&lt;T1,T2,TType&gt;](Either{T1,T2,TType}.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>')  
&#8627; [Ordered&lt;T1,T2,TType&gt;](Ordered{T1,T2,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,TType>')

Implements [IEither](IEither.md 'Emik.Unions.Disjoints.IEither'), [IProperties](IProperties.md 'Emik.Unions.IProperties')

| Properties | |
| :--- | :--- |
| [First](IEither{T1,T2}.First.md 'Emik.Unions.Disjoints.IEither<T1,T2>.First') | Gets the [T1](IEither{T1,T2}.md#Emik.Unions.Disjoints.IEither_T1,T2_.T1 'Emik.Unions.Disjoints.IEither<T1,T2>.T1') first value of the disjoint union. |
| [Second](IEither{T1,T2}.Second.md 'Emik.Unions.Disjoints.IEither<T1,T2>.Second') | Gets the [T2](IEither{T1,T2}.md#Emik.Unions.Disjoints.IEither_T1,T2_.T2 'Emik.Unions.Disjoints.IEither<T1,T2>.T2') second value of the disjoint union. |
