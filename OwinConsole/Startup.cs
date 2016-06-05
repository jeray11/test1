using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OwinConsole.Startup))]
namespace OwinConsole
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.c();
            app.UseErrorPage();
            app.Run(context =>
            {
                // New code: Throw an exception for this URI path.
                if (context.Request.Path.Value == "/fail")
                {
                    throw new Exception("Random exception");
                }

                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            //app.Run(context=> {
            //    context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync("hello world.");
            //});
        }
    }
}
