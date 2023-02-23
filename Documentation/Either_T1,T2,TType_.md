#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints')

## Either<T1,T2,TType> Class

Defines an inheritable record that automates logic for a disjoint union.

```csharp
public abstract class Either<T1,T2,TType> :
Emik.Unions.Disjoints.IEither<T1, T2>,
Emik.Unions.Disjoints.IEither,
Emik.Unions.IProperties,
System.IEquatable<Emik.Unions.Disjoints.Either<T1, T2, TType>>
    where T1 : notnull
    where T2 : notnull
    where TType : Emik.Unions.Disjoints.Either<T1, T2, TType>
```
#### Type parameters

<a name='Emik.Unions.Disjoints.Either_T1,T2,TType_.T1'></a>

`T1`

The first type of the disjoint union.

<a name='Emik.Unions.Disjoints.Either_T1,T2,TType_.T2'></a>

`T2`

The second type of the disjoint union.

<a name='Emik.Unions.Disjoints.Either_T1,T2,TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Either<T1,T2,TType>

Derived  
&#8627; [Overload&lt;T1,T2&gt;](Overload_T1,T2_.md 'Emik.Unions.Disjoints.Overload<T1,T2>')

Implements [Emik.Unions.Disjoints.IEither&lt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T1](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.T1 'Emik.Unions.Disjoints.Either<T1,T2,TType>.T1')[,](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>')[T2](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.T2 'Emik.Unions.Disjoints.Either<T1,T2,TType>.T2')[&gt;](IEither_T1,T2_.md 'Emik.Unions.Disjoints.IEither<T1,T2>'), [IEither](IEither.md 'Emik.Unions.Disjoints.IEither'), [IProperties](IProperties.md 'Emik.Unions.IProperties'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Disjoints.Either&lt;](Either_T1,T2,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>')[T1](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.T1 'Emik.Unions.Disjoints.Either<T1,T2,TType>.T1')[,](Either_T1,T2,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>')[T2](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.T2 'Emik.Unions.Disjoints.Either<T1,T2,TType>.T2')[,](Either_T1,T2,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>')[TType](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,TType>.TType')[&gt;](Either_T1,T2,TType_.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Properties | |
| :--- | :--- |
| [this[int]](Either_T1,T2,TType_.Item.7LZM6OXkj+leTG9DzUlVwQ.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>.this[int]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property of the type based on the index passed in. |

| Methods | |
| :--- | :--- |
| [New(T1)](Either_T1,T2,TType_.New.X7aBVQeiuWtHLFu1eYPoyw.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>.New(T1)') | Creates a new instance of [TType](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,TType>.TType') with<br/>the [T2](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.T2 'Emik.Unions.Disjoints.Either<T1,T2,TType>.T2') value being set. |
| [New(T2)](Either_T1,T2,TType_.New.PoujcLi0qjrbFTT7gI95RQ.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>.New(T2)') | Creates a new instance of [TType](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.TType 'Emik.Unions.Disjoints.Either<T1,T2,TType>.TType') with<br/>the [T2](Either_T1,T2,TType_.md#Emik.Unions.Disjoints.Either_T1,T2,TType_.T2 'Emik.Unions.Disjoints.Either<T1,T2,TType>.T2') value being set. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Unions.Disjoints.IEither.Index](Either_T1,T2,TType_.Emik.Unions.Disjoints.IEither.Index.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>.Emik.Unions.Disjoints.IEither.Index') | Gets the index where the value is contained. |
| [Emik.Unions.Disjoints.IEither.Value](Either_T1,T2,TType_.Emik.Unions.Disjoints.IEither.Value.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>.Emik.Unions.Disjoints.IEither.Value') | Gets the value. |
| [Emik.Unions.IProperties.Properties](Either_T1,T2,TType_.Emik.Unions.IProperties.Properties.md 'Emik.Unions.Disjoints.Either<T1,T2,TType>.Emik.Unions.IProperties.Properties') | Gets all properties of this type. |
