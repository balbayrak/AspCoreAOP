using AspCoreAOP.Core.Concrete;
using AspCoreDependency.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AspCoreAOP.Core.Abstract
{
    public interface IProxySelector : ISingletonType, IDisposable
    {
        bool ShouldInterceptMethod(Type type, MethodInfo methodInfo);

        bool ShouldInterceptType(Type type);

        bool ShouldInterceptTypes(List<Type> types);

        List<InterceptorType> GetInterceptMethodInterceptors(Type type, MethodInfo methodInfo);

        List<InterceptorType> GetInterceptTypeInterceptors(Type type);

    }
}
