using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace MyOwinWebApi.Core.MyMiddleware
{
    public class AopMiddleware : OwinMiddleware
    {
        public AopMiddleware(OwinMiddleware next) : base(next)
        {
            Next = next;
        }

        /// <summary>
        /// 此处必须使用 async/await，如果不用，而是写return Next.Invoke(context);则Console.WriteLine("POST AOP...");无法输出
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task Invoke(IOwinContext context)
        {
            OnInvoking(context);
            await Next.Invoke(context);
            OnInvoked(context);
        }

        protected virtual void OnInvoking(IOwinContext context)
        {
            Console.WriteLine(this.ToString()+".OnInvoking...");
        }

        protected virtual void OnInvoked(IOwinContext context)
        {
            Console.WriteLine(this.ToString() + ".OnInvoked...");
        }
    }
}
