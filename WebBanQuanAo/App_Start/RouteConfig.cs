using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebBanQuanAo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("QuanAoNam1", "{type}-{meta}",
            new { controller = "QuanAoNam", action = "QuanAoNam1", meta = UrlParameter.Optional },
            new RouteValueDictionary
            {
                {"type","san-pham"}
            },
            namespaces: new[] { "WebBanQuanAo.Controllers" });

            routes.MapRoute(
                name: "QuanAoNu1",
                url: "san-pham/{meta}",
                defaults: new { controller = "QuanAoNu", action = "QuanAoNu1", meta = UrlParameter.Optional },
                namespaces: new[] { "ShopGiay.Controllers" }
             );
            routes.MapRoute("QuanAoNam", "{type}/{meta}",
            new { controller = "QuanAoNam", action = "QuanAoNam", meta = UrlParameter.Optional },
            new RouteValueDictionary
            {
                {"type","san-pham"}
            },
            namespaces: new[] { "WebBanQuanAo.Controllers" });

            routes.MapRoute("Detail", "{type}/{meta}/{id}",
            new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
            new RouteValueDictionary
            {
                {"type","san-pham"}
            },
            namespaces: new[] { "WebBanQuanAo.Controllers" });
            routes.MapRoute("Home", "{type}",
              new { Controller = "Default", action = "Index"},
              new RouteValueDictionary
              {
                    {"type","trang-chu" }
              },
              namespaces: new[] { "WebBanQuanAo.Controllers" }
              );
            routes.MapRoute("News", "{type}",
            new { Controller = "News", action = "Index" },
            new RouteValueDictionary
            {
                    {"type","tin-tuc" }
            },
            namespaces: new[] { "WebBanQuanAo.Controllers" }
            );
            routes.MapRoute("Contact", "{type}",
           new { Controller = "Contact", action = "Index" },
           new RouteValueDictionary
           {
                    {"type","lien-he" }
           },
           namespaces: new[] { "WebBanQuanAo.Controllers" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "WebBanQuanAo.Controllers" }
           
            );
        }
    }
}
