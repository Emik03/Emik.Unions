#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints')

## Either<T1,T2,T3,T4,T5,TType> Class

Defines an inheritable record that automates logic for a disjoint union.

```csharp
public abstract class Either<T1,T2,T3,T4,T5,TType> :
Emik.Unions.Disjoints.IEither<T1, T2, T3, T4, T5>,
Emik.Unions.Disjoints.IEither,
Emik.Unions.IProperties,
System.IEquatable<Emik.Unions.Disjoints.Either<T1, T2, T3, T4, T5, TType>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where TType : Emik.Unions.Disjoints.Either<T1, T2, T3, T4, T5, TType>
```
#### Type parameters

<a name='Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T1'></a>

`T1`

The first type of the disjoint union.

<a name='Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T2'></a>

`T2`

The second type of the disjoint union.

<a name='Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T3'></a>

`T3`

The third type of the disjoint union.

<a name='Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T4'></a>

`T4`

The fourth type of the disjoint union.

<a name='Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T5'></a>

`T5`

The fifth type of the disjoint union.

<a name='Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Either<T1,T2,T3,T4,T5,TType>

Derived  
&#8627; [Overload&lt;T1,T2,T3,T4,T5&gt;](Overload_T1,T2,T3,T4,T5_.md 'Emik.Unions.Disjoints.Overload<T1,T2,T3,T4,T5>')

Implements [Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2,T3,T4,T5_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T1](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T1 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T1')[,](IEither_T1,T2,T3,T4,T5_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T2](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T2 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T2')[,](IEither_T1,T2,T3,T4,T5_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T3](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T3 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T3')[,](IEither_T1,T2,T3,T4,T5_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T4](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T4 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T4')[,](IEither_T1,T2,T3,T4,T5_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>')[T5](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T5 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T5')[&gt;](IEither_T1,T2,T3,T4,T5_.md 'Emik.Unions.Disjoints.IEither<T1,T2,T3,T4,T5>'), [IEither](IEither.md 'Emik.Unions.Disjoints.IEither'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Disjoints.Either&lt;](Either_T1,T2,T3,T4,T5,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>')[T1](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T1 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T1')[,](Either_T1,T2,T3,T4,T5,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>')[T2](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T2 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T2')[,](Either_T1,T2,T3,T4,T5,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>')[T3](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T3 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T3')[,](Either_T1,T2,T3,T4,T5,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>')[T4](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T4 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T4')[,](Either_T1,T2,T3,T4,T5,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>')[T5](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T5 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T5')[,](Either_T1,T2,T3,T4,T5,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>')[TType](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.TType')[&gt;](Either_T1,T2,T3,T4,T5,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Properties | |
| :--- | :--- |
| [this[int]](Either_T1,T2,T3,T4,T5,TType_.Item(Int32).md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |

| Methods | |
| :--- | :--- |
| [New(T1)](Either_T1,T2,T3,T4,T5,TType_.New(T1).md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.New(T1)') | Creates a new instance of [TType](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.TType') with<br/>the [T5](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T5 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T5') value being set. |
| [New(T2)](Either_T1,T2,T3,T4,T5,TType_.New(T2).md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.New(T2)') | Creates a new instance of [TType](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.TType') with<br/>the [T5](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T5 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T5') value being set. |
| [New(T3)](Either_T1,T2,T3,T4,T5,TType_.New(T3).md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.New(T3)') | Creates a new instance of [TType](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.TType') with<br/>the [T5](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T5 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T5') value being set. |
| [New(T4)](Either_T1,T2,T3,T4,T5,TType_.New(T4).md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.New(T4)') | Creates a new instance of [TType](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.TType') with<br/>the [T5](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T5 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T5') value being set. |
| [New(T5)](Either_T1,T2,T3,T4,T5,TType_.New(T5).md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.New(T5)') | Creates a new instance of [TType](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.TType') with<br/>the [T5](Either_T1,T2,T3,T4,T5,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,T3,T4,T5,TType_.T5 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.T5') value being set. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.Disjoints.IEither.Index](Either_T1,T2,T3,T4,T5,TType_.Emik.Unions.Disjoints.IEither.Index().md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.Emik.Unions.Disjoints.IEither.Index') | Gets the index where the value is contained. |
| [Emik.Unions.Disjoints.IEither.Value](Either_T1,T2,T3,T4,T5,TType_.Emik.Unions.Disjoints.IEither.Value().md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.Emik.Unions.Disjoints.IEither.Value') | Gets the value. |
| [Emik.Unions.IProperties.Properties](Either_T1,T2,T3,T4,T5,TType_.Emik.Unions.IProperties.Properties().md 'Emik.Unions.Disjoints.Either<T1,T2,T3,T4,T5,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
