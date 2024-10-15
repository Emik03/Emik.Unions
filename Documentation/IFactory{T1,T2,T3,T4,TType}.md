#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## IFactory<T1,T2,T3,T4,TType> Interface

Defines an interface for a factory method with argument length 4.

```csharp
public interface IFactory<in T1,in T2,in T3,in T4,out TType>
```
#### Type parameters

<a name='Emik.Unions.Tagged.IFactory_T1,T2,T3,T4,TType_.T1'></a>

`T1`

The first argument for the factory.

<a name='Emik.Unions.Tagged.IFactory_T1,T2,T3,T4,TType_.T2'></a>

`T2`

The second argument for the factory.

<a name='Emik.Unions.Tagged.IFactory_T1,T2,T3,T4,TType_.T3'></a>

`T3`

The third argument for the factory.

<a name='Emik.Unions.Tagged.IFactory_T1,T2,T3,T4,TType_.T4'></a>

`T4`

The fourth argument for the factory.

<a name='Emik.Unions.Tagged.IFactory_T1,T2,T3,T4,TType_.TType'></a>

`TType`

The resulting type from the factory.

Derived  
&#8627; [Product&lt;T1,T2,T3,T4,TType&gt;](Product{T1,T2,T3,T4,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')

| Methods | |
| :--- | :--- |
| [New(T1, T2, T3, T4)](IFactory{T1,T2,T3,T4,TType}.New(T1,T2,T3,T4).md 'Emik.Unions.Tagged.IFactory<T1,T2,T3,T4,TType>.New(T1, T2, T3, T4)') | Creates the new instance of [TType](IFactory{T1,T2,T3,T4,TType}.md#Emik.Unions.Tagged.IFactory_T1,T2,T3,T4,TType_.TType 'Emik.Unions.Tagged.IFactory<T1,T2,T3,T4,TType>.TType') with the given arguments. |
