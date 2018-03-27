using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace MyOwinWebApi.Core.MyMiddleware
{
    public class LoggerMiddleware : AopMiddleware
    {
        public LoggerMiddleware(OwinMiddleware next) : base(next)
        {
            Next = next;
        }

        protected override void OnInvoking(IOwinContext context)
        {
            //base.OnInvoking(context);
            Console.WriteLine(this.ToString()+".OnInvoking...");
        }

        protected override void OnInvoked(IOwinContext context)
        {
            //base.OnInvoked(context);
            Console.WriteLine(this.ToString() + ".OnInvoked...");
        }
    }
}
