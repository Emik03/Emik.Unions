#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged').[IFactory&lt;T1,T2,TType&gt;](IFactory{T1,T2,TType}.md 'Emik.Unions.Tagged.IFactory<T1,T2,TType>')

## IFactory<T1,T2,TType>.New(T1, T2) Method

Creates the new instance of [TType](IFactory{T1,T2,TType}.md#Emik.Unions.Tagged.IFactory_T1,T2,TType_.TType 'Emik.Unions.Tagged.IFactory<T1,T2,TType>.TType') with the given arguments.

```csharp
abstract static TType New(T1 first, T2 second);
```
#### Parameters

<a name='Emik.Unions.Tagged.IFactory_T1,T2,TType_.New(T1,T2).first'></a>

`first` [T1](IFactory{T1,T2,TType}.md#Emik.Unions.Tagged.IFactory_T1,T2,TType_.T1 'Emik.Unions.Tagged.IFactory<T1,T2,TType>.T1')

The first argument of the factory.

<a name='Emik.Unions.Tagged.IFactory_T1,T2,TType_.New(T1,T2).second'></a>

`second` [T2](IFactory{T1,T2,TType}.md#Emik.Unions.Tagged.IFactory_T1,T2,TType_.T2 'Emik.Unions.Tagged.IFactory<T1,T2,TType>.T2')

The second argument of the factory.

#### Returns
[TType](IFactory{T1,T2,TType}.md#Emik.Unions.Tagged.IFactory_T1,T2,TType_.TType 'Emik.Unions.Tagged.IFactory<T1,T2,TType>.TType')  
The new [TType](IFactory{T1,T2,TType}.md#Emik.Unions.Tagged.IFactory_T1,T2,TType_.TType 'Emik.Unions.Tagged.IFactory<T1,T2,TType>.TType') instance with the values of the arguments.