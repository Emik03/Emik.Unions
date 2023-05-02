#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings')

## Self<T> Class

A functor that returns itself.

```csharp
public sealed class Self<T> : Emik.Unions.Mappings.Functor<T, T, Emik.Unions.Mappings.Self<T>>,
System.IEquatable<Emik.Unions.Mappings.Self<T>>
```
#### Type parameters

<a name='Emik.Unions.Mappings.Self_T_.T'></a>

`T`

The encapsulating type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Emik.Unions.Mappings.Functor&lt;](Functor_TType_.md 'Emik.Unions.Mappings.Functor<TType>')[Emik.Unions.Mappings.Self&lt;](Self_T_.md 'Emik.Unions.Mappings.Self<T>')[T](Self_T_.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[&gt;](Self_T_.md 'Emik.Unions.Mappings.Self<T>')[&gt;](Functor_TType_.md 'Emik.Unions.Mappings.Functor<TType>') &#129106; [Emik.Unions.Mappings.Functor&lt;](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[T](Self_T_.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[,](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[T](Self_T_.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[,](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')[Emik.Unions.Mappings.Self&lt;](Self_T_.md 'Emik.Unions.Mappings.Self<T>')[T](Self_T_.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[&gt;](Self_T_.md 'Emik.Unions.Mappings.Self<T>')[&gt;](Functor_T,TResult,TType_.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>') &#129106; Self<T>

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Emik.Unions.Mappings.Self&lt;](Self_T_.md 'Emik.Unions.Mappings.Self<T>')[T](Self_T_.md#Emik.Unions.Mappings.Self_T_.T 'Emik.Unions.Mappings.Self<T>.T')[&gt;](Self_T_.md 'Emik.Unions.Mappings.Self<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Self(T)](Self_T_..ctor(T).md 'Emik.Unions.Mappings.Self<T>.Self(T)') | A functor that returns itself. |

| Properties | |
| :--- | :--- |
| [Value](Self_T_.Value().md 'Emik.Unions.Mappings.Self<T>.Value') | The encapsulated value. |
