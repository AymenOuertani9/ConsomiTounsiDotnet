using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConsommiTounsi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "SignIn", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Dashboard",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Dashboard", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "Stock",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Stock", action = "Index", id = UrlParameter.Optional }
        );
          
            routes.MapRoute(
               name: "User",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "User", action = "SignUp", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "ManageUsers",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "User", action = "ManageUsers", id = UrlParameter.Optional }
           );


         
        }
    }
}
