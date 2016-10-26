using SimpleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            */

            // for the purpose of this exercise, we are going to explicitly make our routes

            // we need to specify the namespece so that posts controllers don't get confused. 
            var namespaces = new[] { typeof(PostsController).Namespace };
            // Home route
            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, namespaces);
            // Login route
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, namespaces);
        }
    }
}
