using AspCoreAOP.Test.Models;
using System;

namespace AspCoreAOP.Test.Abstract
{
    public interface IService
    {
        public Guid id { get; }
        public OutputDTO Run(InputDTO input);
    }
}
