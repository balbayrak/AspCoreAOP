using AspCoreAOP.Test.Abstract;
using AspCoreAOP.Test.Models;

namespace AspCoreAOP.Test.Concrete
{
    public class ManagerB : BaseManager, IServiceB
    {
        public override OutputDTO Run(InputDTO input)
        {
            return new OutputDTO
            {
                str = $"{this.GetType().Name} run with id: {this.id}"
            };
        }
    }
}
