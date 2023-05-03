#### [Emik.Unions](index.md 'index')
### [Emik.Unions.Tagged](Emik.Unions.Tagged.md 'Emik.Unions.Tagged')

## IProduct Interface

Provides an indexer.

```csharp
public interface IProduct :
Emik.Unions.IPropertyEnumerable,
Emik.Unions.IProperties
```

Derived  
&#8627; [Functor&lt;T,TResult,TType&gt;](Functor{T,TResult,TType}.md 'Emik.Unions.Mappings.Functor<T,TResult,TType>')  
&#8627; [IProduct&lt;T1,T2,T3,T4&gt;](IProduct{T1,T2,T3,T4}.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3,T4>')  
&#8627; [IProduct&lt;T1,T2,T3&gt;](IProduct{T1,T2,T3}.md 'Emik.Unions.Tagged.IProduct<T1,T2,T3>')  
&#8627; [IProduct&lt;T1,T2&gt;](IProduct{T1,T2}.md 'Emik.Unions.Tagged.IProduct<T1,T2>')  
&#8627; [IProduct&lt;T1&gt;](IProduct{T1}.md 'Emik.Unions.Tagged.IProduct<T1>')  
&#8627; [Product&lt;T1,T2,T3,T4,TType&gt;](Product{T1,T2,T3,T4,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,T3,T4,TType>')  
&#8627; [Product&lt;T1,T2,T3,TType&gt;](Product{T1,T2,T3,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,T3,TType>')  
&#8627; [Product&lt;T1,T2,TType&gt;](Product{T1,T2,TType}.md 'Emik.Unions.Tagged.Product<T1,T2,TType>')  
&#8627; [Product&lt;T1,TType&gt;](Product{T1,TType}.md 'Emik.Unions.Tagged.Product<T1,TType>')

Implements [IPropertyEnumerable](IPropertyEnumerable.md 'Emik.Unions.IPropertyEnumerable'), [IProperties](IProperties.md 'Emik.Unions.IProperties')

| Properties | |
| :--- | :--- |
| [this[string]](IProduct.Item(String).md 'Emik.Unions.Tagged.IProduct.this[string]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the name. |
| [this[PropertyInfo]](IProduct.Item(PropertyInfo).md 'Emik.Unions.Tagged.IProduct.this[System.Reflection.PropertyInfo]') | Gets an [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') corresponding to the property. |
