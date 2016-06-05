using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace OwinWeb
{
    public class Global : System.Web.HttpApplication
    {

        // How to hook OWIN pipelines into the normal Asp.Net route table side by side with other components.
        protected void Application_Start(object sender, EventArgs e)
        {
            // Paths that start with /owin will be directed to our startup class.
            RouteTable.Routes.MapOwinPath("/owin");

            RouteTable.Routes.MapOwinPath("/special", app =>
            {
                app.Run(OwinApp2.Invoke);
            });
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}