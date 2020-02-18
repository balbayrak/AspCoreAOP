using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AspCoreAOP.Core.Abstract
{
    public interface IInvocation
    {
        MethodInfo targetMethod { get; set; }
        object[] args { get; set; }

        object result { get; set; }

        bool isProceeded { get; }

        void Proceed();
    }
}
