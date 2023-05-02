#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings')

## Functor<TType> Class

Defines a functor of unspecified types.

```csharp
public abstract class Functor<TType> :
System.IEquatable<Emik.Unions.Mappings.Functor<TType>>
    where TType : Emik.Unions.Mappings.Functor<TType>
```
#### Type parameters

<a name='Emik.Unions.Mappings.Functor_TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Functor<TType>

Derived  
&#8627; [Functor&lt;T,TResult,TType&gt;](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Mappings.Functor&lt;](Functor_TType_.md 'Emik.Unions.Mappings.Functor<TType>')[TType](Functor_TType_.md#Emik.Unions.Mappings.Functor_TType_.TType 'Emik.Unions.Mappings.Functor<TType>.TType')[&gt;](Functor_TType_.md 'Emik.Unions.Mappings.Functor<TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Functor()](Functor_TType_..ctor().md 'Emik.Unions.Mappings.Functor<TType>.Functor()') | Initializes a new instance of the [Functor&lt;TType&gt;](Functor_TType_.md 'Emik.Unions.Mappings.Functor<TType>') class by updating [Instance](Functor_TType_.Instance().md 'Emik.Unions.Mappings.Functor<TType>.Instance'). |

| Properties | |
| :--- | :--- |
| [Instance](Functor_TType_.Instance().md 'Emik.Unions.Mappings.Functor<TType>.Instance') | Gets the shared instance. |
| [New](Functor_TType_.New().md 'Emik.Unions.Mappings.Functor<TType>.New') | Gets or sets the method used to create an instance of [TType](Functor_TType_.md#Emik.Unions.Mappings.Functor_TType_.TType 'Emik.Unions.Mappings.Functor<TType>.TType') without parameters.<br/>This is meant to be set in a static constructor to intercept the creation of [Instance](Functor_TType_.Instance().md 'Emik.Unions.Mappings.Functor<TType>.Instance'). |
