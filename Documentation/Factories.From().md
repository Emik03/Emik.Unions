#### [Emik.Unions](index.md 'index')
### [Emik.Unions](Emik.Unions.md 'Emik.Unions').[Factories](Factories.md 'Emik.Unions.Factories')

## Factories.From<T1,T2,T3,T4,T5,TType>() Method

Creates a factory from a given type.

```csharp
public static Result<System.Func<T1,T2,T3,T4,T5,TType>,System.MissingMethodException> From<T1,T2,T3,T4,T5,TType>()
    where TType : notnull;
```
#### Type parameters

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().T1'></a>

`T1`

The first type of [TType](Factories.From().md#Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,T5,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().T2'></a>

`T2`

The second type of [TType](Factories.From().md#Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,T5,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().T3'></a>

`T3`

The third type of [TType](Factories.From().md#Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,T5,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().T4'></a>

`T4`

The fourth type of [TType](Factories.From().md#Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,T5,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().T5'></a>

`T5`

The fifth type of [TType](Factories.From().md#Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,T5,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().TType'></a>

`TType`

The type to create the factory from.

#### Returns
[Emik.Results.Result](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result 'Emik.Results.Result')  
A generated factory.

#### Exceptions

[System.MissingMemberException](https://docs.microsoft.com/en-us/dotnet/api/System.MissingMemberException 'System.MissingMemberException')  
There is no constructor on [TType](Factories.From().md#Emik.Unions.Factories.From_T1,T2,T3,T4,T5,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,T5,TType>().TType') that matches the signature of the return factory.