using AspCoreAOP.Core.Abstract;

namespace AspCoreAOP.Core.Concrete
{
    public class InterceptorContext : IInterceptorContext
    {
        public IInvocation invocation { get; set; }
    }
}
