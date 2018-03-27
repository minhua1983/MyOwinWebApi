using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using System.Net.Http.Formatting;
using MyOwinWebApi.Core.MyMiddleware;

[assembly: OwinStartup(typeof(MyOwinWebApi.Core.Startup))]

namespace MyOwinWebApi.Core
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //*按顺序注册中间件
            app.Use<LoggerMiddleware>();
            app.Use<AuthorizationMiddleware>();
            //*/

            //*配置webapi路由，返回格式，并启用webapi
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration httpConfiguration = new HttpConfiguration();
            httpConfiguration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",//其中action指的就是方法名,这种方式可以直接按http://localhost:9000/api/valuesparam/getproduct的方式访问  
                defaults: new { id = RouteParameter.Optional }//Optional表明routeTemplate中的id是可选的  
            );
            //删除xml格式启用json格式
            httpConfiguration.Formatters.Clear();
            //JsonMediaTypeFormatter需要引用System.Net.Http.Formatting;
            httpConfiguration.Formatters.Add(new JsonMediaTypeFormatter());
            app.UseWebApi(httpConfiguration);
            //*/
        }
    }
}
