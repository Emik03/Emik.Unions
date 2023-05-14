#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## IFactory<T1,TType> Interface

Defines an interface for a factory method with argument length 1.

```csharp
public interface IFactory<in T1,out TType>
```
#### Type parameters

<a name='Emik.Unions.Tagged.IFactory_T1,TType_.T1'></a>

`T1`

The first argument for the factory.

<a name='Emik.Unions.Tagged.IFactory_T1,TType_.TType'></a>

`TType`

The resulting type from the factory.

Derived  
&#8627; [Product&lt;T1,TType&gt;](Product{T1,TType}.md 'Emik.Unions.Tagged.Product<T1,TType>')

| Methods | |
| :--- | :--- |
| [New(T1)](IFactory{T1,TType}.New(T1).md 'Emik.Unions.Tagged.IFactory<T1,TType>.New(T1)') | Creates the new instance of [TType](IFactory{T1,TType}.md#Emik.Unions.Tagged.IFactory_T1,TType_.TType 'Emik.Unions.Tagged.IFactory<T1,TType>.TType') with the given arguments. |
