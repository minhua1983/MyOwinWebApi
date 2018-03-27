using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace MyOwinWebApi.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebApp来自Microsoft.Owin.Hosting，但是必须引用Microsoft.Owin.Host.HttpListener，否则会报错。Controller目录可以任意命名，但是Controller类必须以Controller为后缀。
            var host = WebApp.Start<Startup>("http://localhost:10000");
            Console.ReadLine();
        }
    }
}
