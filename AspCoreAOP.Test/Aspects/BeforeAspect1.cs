using AspCoreAOP.Core.Abstract;
using AspCoreAOP.Core.Concrete;
using AspCoreAOP.Test.Models;

namespace AspCoreAOP.Test.Aspects
{
    public class BeforeAspect1 : InterceptorBase, IBeforeInterceptor
    {
        public BeforeAspect1()
        {

        }
        public BeforeAspect1(InterceptorContext context) : base(context)
        {

        }
        public void OnBefore()
        {
            InputDTO input = this._context.invocation.args[0] as InputDTO;
            if (input != null)
            {
                input.str = $"Before Aspect1 Work before method" + input.str;
            }
        }
    }
}
