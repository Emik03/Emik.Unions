#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Mappings](Emik.Unions.Mappings.md 'Emik.Unions.Mappings').[Functor&lt;TType&gt;](Functor_TType_.md 'Emik.Unions.Mappings.Functor<TType>')

## Functor<TType>.New Property

Gets or sets the method used to create an instance of [TType](Functor_TType_.md#Emik.Unions.Mappings.Functor_TType_.TType 'Emik.Unions.Mappings.Functor<TType>.TType') without parameters.  
This is meant to be set in a static constructor to intercept the creation of [Instance](Functor_TType_.Instance().md 'Emik.Unions.Mappings.Functor<TType>.Instance').

```csharp
protected static System.Func<TType> New { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TType](Functor_TType_.md#Emik.Unions.Mappings.Functor_TType_.TType 'Emik.Unions.Mappings.Functor<TType>.TType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')