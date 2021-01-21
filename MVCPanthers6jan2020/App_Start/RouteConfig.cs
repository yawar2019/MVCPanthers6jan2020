using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCPanthers6jan2020
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

           

            routes.MapRoute(
                name: "Default1",
                url: "Sample/MyTestRoute",
                defaults: new { controller = "New", action = "GetTestData4", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Default", action = "GetIndex", id = UrlParameter.Optional }
           );

        }
    }
}
