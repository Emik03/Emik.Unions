#### [Emik.Unions](index.md 'index')
### [Emik.Unions](Emik.Unions.md 'Emik.Unions').[Factories](Factories.md 'Emik.Unions.Factories')

## Factories.From<T1,T2,T3,T4,TType>() Method

Creates a factory from a given type.

```csharp
public static Emik.Results.Result<System.Func<T1,T2,T3,T4,TType>,System.MissingMethodException> From<T1,T2,T3,T4,TType>()
    where TType : notnull;
```
#### Type parameters

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().T1'></a>

`T1`

The first type of [TType](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().T2'></a>

`T2`

The second type of [TType](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().T3'></a>

`T3`

The third type of [TType](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().T4'></a>

`T4`

The fourth type of [TType](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().TType').

<a name='Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().TType'></a>

`TType`

The type to create the factory from.

#### Returns
[Emik.Results.Result&lt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().T1 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().T2 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().T3 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().T4 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TType](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().TType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[,](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')[System.MissingMethodException](https://docs.microsoft.com/en-us/dotnet/api/System.MissingMethodException 'System.MissingMethodException')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2 'Emik.Results.Result`2')  
A generated factory.

#### Exceptions

[System.MissingMemberException](https://docs.microsoft.com/en-us/dotnet/api/System.MissingMemberException 'System.MissingMemberException')  
There is no constructor on [TType](Factories.From{T1,T2,T3,T4,TType}.md#Emik.Unions.Factories.From_T1,T2,T3,T4,TType_().TType 'Emik.Unions.Factories.From<T1,T2,T3,T4,TType>().TType') that matches the signature of the return factory.