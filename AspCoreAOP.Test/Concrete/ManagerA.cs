using AspCoreAOP.Test.Abstract;
using AspCoreAOP.Test.Models;

namespace AspCoreAOP.Test.Concrete
{
    public class ManagerA : BaseManager, IServiceA
    {
        public override OutputDTO Run(InputDTO input)
        {
            return new OutputDTO
            {
                str = $"Input : {input.str} \n {this.GetType().Name} run with id: {this.id}"
            };
        }
    }
}
