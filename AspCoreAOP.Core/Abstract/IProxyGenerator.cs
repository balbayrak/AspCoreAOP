using System;

namespace AspCoreAOP.Core.Abstract
{
    public interface IProxyGenerator
    {
        object Create(Type serviceType, Type implementationType, object implementationObj, IInterceptorContext context);
    }
}
