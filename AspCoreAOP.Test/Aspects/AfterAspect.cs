using AspCoreAOP.Core.Abstract;
using AspCoreAOP.Core.Concrete;
using AspCoreAOP.Test.Models;

namespace AspCoreAOP.Test.Aspects
{
    public class AfterAspect : InterceptorBase, IAfterInterceptor
    {
        public AfterAspect()
        {

        }
        public AfterAspect(InterceptorContext context) : base(context)
        {

        }

        public void OnAfter()
        {
            ((OutputDTO)this._context.invocation.result).str += " \n Aspect work after method";
        }
    }
}
