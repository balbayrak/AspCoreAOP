using AspCoreAOP.Test.Abstract;
using AspCoreAOP.Test.Aspects;
using AspCoreAOP.Test.Models;

namespace AspCoreAOP.Test.Concrete
{
    [ExceptionAspect]
    public class ManagerC : BaseManager, IServiceC
    {
        public override OutputDTO Run(InputDTO input)
        {
            throw new System.Exception($"{ this.GetType().Name } throw exception.");
            //return new OutputDTO
            //{
            //    str = $"{this.GetType().Name} run with id: {this.id}"
            //};
        }
    }
}
