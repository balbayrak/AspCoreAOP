using AspCoreAOP.Core.Abstract;
using AspCoreAOP.Core.Concrete;
using AspCoreAOP.Test.Models;
using System;

namespace AspCoreAOP.Test.Aspects
{
    public class ExceptionAspect : InterceptorBase, IExceptionInterceptor
    {
        public ExceptionAspect()
        {

        }
        public ExceptionAspect(InterceptorContext context) : base(context)
        {

        }

        public void OnException(Exception exception)
        {
            this._context.invocation.result = new OutputDTO
            {
                str = exception.InnerException.Message
            };
        }
    }
}
