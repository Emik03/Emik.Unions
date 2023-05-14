#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings')

## Functor<TType> Class

Defines a functor of unspecified types.

```csharp
public abstract class Functor<TType> :
System.Numerics.IEqualityOperators<Emik.Unions.Mappings.Functor<TType>, Emik.Unions.Mappings.Functor<TType>, bool>,
System.IEquatable<Emik.Unions.Mappings.Functor<TType>>
    where TType : Emik.Unions.Mappings.Functor<TType>
```
#### Type parameters

<a name='Emik.Unions.Mappings.Functor_TType_.TType'></a>

`TType`

The type of the inheriting record.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Functor<TType>

Derived  
&#8627; [Functor&lt;T,TResult,TType&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')

Implements [System.Numerics.IEqualityOperators&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Mappings.Functor&lt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>')[TType](Functor{TType}.md#Emik.Unions.Mappings.Functor_TType_.TType 'Emik.Unions.Mappings.Functor<TType>.TType')[&gt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Mappings.Functor&lt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>')[TType](Functor{TType}.md#Emik.Unions.Mappings.Functor_TType_.TType 'Emik.Unions.Mappings.Functor<TType>.TType')[&gt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Mappings.Functor&lt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>')[TType](Functor{TType}.md#Emik.Unions.Mappings.Functor_TType_.TType 'Emik.Unions.Mappings.Functor<TType>.TType')[&gt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Functor()](Functor{TType}..ctor.md 'Emik.Unions.Mappings.Functor<TType>.Functor()') | Initializes a new instance of the [Functor&lt;TType&gt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>') class by updating [Instance](Functor{TType}.Instance.md 'Emik.Unions.Mappings.Functor<TType>.Instance'). |

| Properties | |
| :--- | :--- |
| [Instance](Functor{TType}.Instance.md 'Emik.Unions.Mappings.Functor<TType>.Instance') | Gets the shared instance. |
| [New](Functor{TType}.New.md 'Emik.Unions.Mappings.Functor<TType>.New') | Gets or sets the method used to create an instance of [TType](Functor{TType}.md#Emik.Unions.Mappings.Functor_TType_.TType 'Emik.Unions.Mappings.Functor<TType>.TType') without parameters.<br/>This is meant to be set in a static constructor to intercept the creation of [Instance](Functor{TType}.Instance.md 'Emik.Unions.Mappings.Functor<TType>.Instance'). |
