# AspCoreAOP

A plugin for *Microsoft.Extensions.DependencyInjection* to support automatically injecting all types which defines *ITransientType*, *IScopedType*, *ISingletonType*, and also injecting makes with interceptors.
It uses *System.Reflection.DispatchProxy* to enable on the fly proxy creation of implementation types.

# How to Use

* **Add DependencyInjection package to your project.**
```
 PM> Install-Package AspCoreAOP.Core
```

* **Create your custom interceptors in your project.**
```csharp
public class BeforeAspect : InterceptorBase, IBeforeInterceptor
{
     public BeforeAspect()
     {}
     public BeforeAspect(InterceptorContext context) : base(context)
     {}
     public void OnBefore()
     {
         InputDTO input = this._context.invocation.args[0] as InputDTO;
         if (input != null)
         {
             input.str = $"Before Aspect Work before method" + input.str;
         }
     }
}

public class AfterAspect : InterceptorBase, IAfterInterceptor
{
     public AfterAspect()
     {}
     public AfterAspect(InterceptorContext context) : base(context)
     {}
     public void OnAfter()
     {
         ((OutputDTO)this._context.invocation.result).str += " \n Aspect work after method";
     }
}

public class ExceptionAspect : InterceptorBase, IExceptionInterceptor
{
     public ExceptionAspect()
     {}
     public ExceptionAspect(InterceptorContext context) : base(context)
     {}
     public void OnException(Exception exception)
     {
         this._context.invocation.result = new OutputDTO
         {
             str = exception.InnerException.Message
         };
     }
}
    
```

* **Service types or implementation types can use attribute for interceptor**
```csharp
   [BeforeAspect(priority = 1)]
   [BeforeAspect1(priority = 2)]
   public interface IServiceA : IService, ISingletonType
   {}
   
   [AfterAspect]
   public interface IServiceB : IService, IScopedType
   {}
   
   [ExceptionAspect]
   public interface IServiceC : IService, ITransientType
   {}
          or
          
   [ExceptionAspect]
   public class ManagerC : BaseManager, IServiceC
   ...
   
```

* **Ensure fire the AutoBindWithInterceptors method in Startup.cs**

```csharp
//ProxySelector used AttributeBaseProxySelector as default.

   services.AutoBindWithInterceptors();
```
```csharp
//ProxySelector used with custom class.

 services.AutoBindWithInterceptors<TProxyGenerator>();
  ```
  ```csharp
 //Two method used with namespace constraint.
 
 services.AutoBindWithInterceptors(option =>
 {
    option.namespaceStr = "AspCoreDependency.Test.Concrete.NameSpace1";
 });
```
# Test Project
You can see all usage in *AspCoreAOP.Test.csproj* project.
