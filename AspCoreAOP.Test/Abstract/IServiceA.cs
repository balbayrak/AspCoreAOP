using AspCoreAOP.Test.Aspects;
using AspCoreDependency.Core.Abstract;

namespace AspCoreAOP.Test.Abstract
{
    [BeforeAspect(priority = 1)]
    [BeforeAspect1(priority = 2)]
    public interface IServiceA : IService, ISingletonType
    {

    }
}
