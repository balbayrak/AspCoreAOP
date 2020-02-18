using AspCoreAOP.Core.Abstract;
using AspCoreAOP.Core.Concrete;
using AspCoreAOP.Test.Models;

namespace AspCoreAOP.Test.Aspects
{
    public class BeforeAspect : InterceptorBase, IBeforeInterceptor
    {
        public BeforeAspect()
        {

        }
        public BeforeAspect(InterceptorContext context) : base(context)
        {

        }
        public void OnBefore()
        {
            InputDTO input = this._context.invocation.args[0] as InputDTO;
            if (input != null)
            {
                input.str = $"Before Aspect Work before method" + input.str;
            }
        }
    }
}
