using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ISM_HomePage
{
    public class Global : HttpApplication
    {
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            bool maintenanceMode = Convert.ToBoolean(ConfigurationManager.AppSettings["MaintenanceMode"]);

            if (maintenanceMode && !HttpContext.Current.Request.Path.Contains("EncryptDecrypt"))
            {
                HttpContext.Current.Response.Redirect("EncryptDecrypt.aspx");
            }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}