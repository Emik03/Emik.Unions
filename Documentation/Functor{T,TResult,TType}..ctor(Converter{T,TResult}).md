#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings').[Functor&lt;T,TResult,TType&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')

## Functor(Converter<T,TResult>) Constructor

Defines a type that acts as a functor and `newtype` idiom from Rust simultaneously.

```csharp
protected Functor(System.Converter<T,TResult> Converter);
```
#### Parameters

<a name='Emik.Unions.Mappings.Functor_T,TResult,TType_.Functor(System.Converter_T,TResult_).Converter'></a>

`Converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.T 'Emik.Unions.Mappings.Functor<T,TResult,TType>.T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](Functor{T,TResult,TType}.md#Emik.Unions.Mappings.Functor_T,TResult,TType_.TResult 'Emik.Unions.Mappings.Functor<T,TResult,TType>.TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The converting function that creates this instance, much like `From` in Rust.