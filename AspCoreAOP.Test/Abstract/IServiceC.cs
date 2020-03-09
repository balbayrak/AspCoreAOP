using AspCoreAOP.Test.Aspects;
using AspCoreDependency.Core.Abstract;

namespace AspCoreAOP.Test.Abstract
{
    [ExceptionAspect]
    public interface IServiceC : IService, ITransientType
    {
    }
}
