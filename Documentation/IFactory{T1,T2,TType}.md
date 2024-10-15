#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## IFactory<T1,T2,TType> Interface

Defines an interface for a factory method with argument length 2.

```csharp
public interface IFactory<in T1,in T2,out TType>
```
#### Type parameters

<a name='Emik.Unions.Tagged.IFactory_T1,T2,TType_.T1'></a>

`T1`

The first argument for the factory.

<a name='Emik.Unions.Tagged.IFactory_T1,T2,TType_.T2'></a>

`T2`

The second argument for the factory.

<a name='Emik.Unions.Tagged.IFactory_T1,T2,TType_.TType'></a>

`TType`

The resulting type from the factory.

Derived  
&#8627; [Product&lt;T1,T2,TType&gt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')

| Methods | |
| :--- | :--- |
| [New(T1, T2)](IFactory{T1,T2,TType}.New(T1,T2).md 'Emik.Unions.Tagged.IFactory<T1,T2,TType>.New(T1, T2)') | Creates the new instance of [TType](IFactory{T1,T2,TType}.md#Emik.Unions.Tagged.IFactory_T1,T2,TType_.TType 'Emik.Unions.Tagged.IFactory<T1,T2,TType>.TType') with the given arguments. |
