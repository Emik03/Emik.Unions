#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Disjoints](Emik.Unions.Disjoints.md 'Emik.Unions.Disjoints')

## IFactories<T1,T2,T3,TType> Interface

Defines an interface for 3 factory methods for each respective type.

```csharp
public interface IFactories<in T1,in T2,in T3,out TType>
```
#### Type parameters

<a name='Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.T1'></a>

`T1`

The first argument for the factory.

<a name='Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.T2'></a>

`T2`

The second argument for the factory.

<a name='Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.T3'></a>

`T3`

The third argument for the factory.

<a name='Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.TType'></a>

`TType`

The resulting type from the factory.

Derived  
&#8627; [Either&lt;T1,T2,T3,TType&gt;](Either{T1,T2,T3,TType}.md 'Emik.Unions.Disjoints.Either<T1,T2,T3,TType>')  
&#8627; [Ordered&lt;T1,T2,T3,TType&gt;](Ordered{T1,T2,T3,TType}.md 'Emik.Unions.Disjoints.Ordered<T1,T2,T3,TType>')

| Methods | |
| :--- | :--- |
| [New(T1)](IFactories{T1,T2,T3,TType}.New(T1).md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.New(T1)') | Creates the new instance of [TType](IFactories{T1,T2,T3,TType}.md#Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.TType 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.TType') from [T1](IFactories{T1,T2,T3,TType}.md#Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.T1 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.T1'). |
| [New(T2)](IFactories{T1,T2,T3,TType}.New(T2).md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.New(T2)') | Creates the new instance of [TType](IFactories{T1,T2,T3,TType}.md#Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.TType 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.TType') from [T2](IFactories{T1,T2,T3,TType}.md#Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.T2 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.T2'). |
| [New(T3)](IFactories{T1,T2,T3,TType}.New(T3).md 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.New(T3)') | Creates the new instance of [TType](IFactories{T1,T2,T3,TType}.md#Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.TType 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.TType') from [T3](IFactories{T1,T2,T3,TType}.md#Emik.Unions.Disjoints.IFactories_T1,T2,T3,TType_.T3 'Emik.Unions.Disjoints.IFactories<T1,T2,T3,TType>.T3'). |
