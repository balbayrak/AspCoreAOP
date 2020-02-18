using System;
using System.Collections.Generic;
using System.Text;
using AspCoreDependency.Core.Abstract;

namespace AspCoreAOP.Core.Abstract
{
    public interface IInterceptorContext : IScopedType
    {
        IInvocation invocation { get; set; }
    }
}
