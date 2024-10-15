#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings')

## Self<T> Class

A functor that returns itself.

```csharp
public sealed class Self<T> : Emik.Unions.Mappings.Functor<T, T, Emik.Unions.Mappings.Self<T>>,
System.Numerics.IEqualityOperators<Emik.Unions.Mappings.Self<T>, Emik.Unions.Mappings.Self<T>, bool>,
System.IEquatable<Emik.Unions.Mappings.Self<T>>
```
#### Type parameters

<a name='Emik.Unions.Mappings.Self_T_.T'></a>

`T`

The encapsulating type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Emik.Unions.Mappings.Functor&lt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>')[Emik.Unions.Mappings.Self&lt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[T](Self{T}.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[&gt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[&gt;](Functor{TType}.md 'Emik.Unions.Mappings.Functor<TType>') &#129106; [Emik.Unions.Mappings.Functor&lt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[T](Self{T}.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[,](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[T](Self{T}.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[,](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[Emik.Unions.Mappings.Self&lt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[T](Self{T}.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[&gt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>') &#129106; Self<T>

Implements [System.Numerics.IEqualityOperators&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Mappings.Self&lt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[T](Self{T}.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[&gt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[Emik.Unions.Mappings.Self&lt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[T](Self{T}.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[&gt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.IEqualityOperators-3 'System.Numerics.IEqualityOperators`3'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Mappings.Self&lt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[T](Self{T}.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[&gt;](Self{T}.md 'Emik.Unions.Mappings.Self<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Self(T)](Self{T}..ctor(T).md 'Emik.Unions.Mappings.Self<T>.Self(T)') | A functor that returns itself. |

| Properties | |
| :--- | :--- |
| [Value](Self{T}.Value.md 'Emik.Unions.Mappings.Self<T>.Value') | The encapsulated value. |
