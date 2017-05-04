using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Gallery
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        
      
            routes.MapRoute(
              name: "Contact",
              url: "Контакт",
              defaults: new { controller = "Home", action = "Contact"}
          );
            routes.MapRoute(
              name: "Portfolio",
              url: "Портфолио",
              defaults: new { controller = "Home", action = "Portfolio"}
          );
            routes.MapRoute(
              name: "Gallery",
              url: "Галерија",
              defaults: new { controller = "Home", action = "Gallery" }
          );
            routes.MapRoute(
           name: "Default",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
       );
        }
    }
}
