using System;

namespace AspCoreAOP.Core.Abstract
{
    public interface IExceptionInterceptor : IInterceptor
    {
        void OnException(Exception exception);
    }
}
