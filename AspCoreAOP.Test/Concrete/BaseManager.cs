using AspCoreAOP.Test.Abstract;
using AspCoreAOP.Test.Models;
using System;

namespace AspCoreAOP.Test.Concrete
{
    public class BaseManager : IService
    {
        public Guid id { get; private set; }
        public BaseManager()
        {
            id = Guid.NewGuid();
        }

        public virtual OutputDTO Run(InputDTO input)
        {
            return null;
        }
    }
}
