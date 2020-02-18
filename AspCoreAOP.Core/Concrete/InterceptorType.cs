using System;

namespace AspCoreAOP.Core.Concrete
{
    public class InterceptorType
    {
        public Type type { get; set; }

        public int priority { get; set; }

        public EnumInterceptorRunType runType { get; set; }
    }
}
