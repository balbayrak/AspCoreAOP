using AspCoreAOP.Test.Aspects;
using AspCoreDependency.Core.Abstract;

namespace AspCoreAOP.Test.Abstract
{
    [AfterAspect]
    public interface IServiceB : IService, IScopedType
    {
    }
}
