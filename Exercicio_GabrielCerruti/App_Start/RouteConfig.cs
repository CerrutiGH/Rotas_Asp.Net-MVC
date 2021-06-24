using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Exercicio_GabrielCerruti
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Noticias",
                url: "Noticias",
                defaults: new {controller = "Noticias", action="Noticias", id = UrlParameter.Optional}
                );
            routes.MapRoute(
                name: "UltimasNoticias",
                url: "Noticias/Ultimas",
                defaults: new { controller = "Home", action = "IndexNoticia", CAT = UrlParameter.Optional }
                );

            routes.MapRoute(
               name: "Cate",
               url: "Noticias/{CAT}",
               defaults: new { controller = "Noticias", action = "LerCategorias", id = UrlParameter.Optional }
               );

            routes.MapRoute(
               name: "LerNoticias",
               url: "Noticias/{CAT}/{TIT}-{id}",
               defaults: new { controller = "Noticias", action = "LerNoticias", id = UrlParameter.Optional }
               );

            routes.MapRoute(
               name: "Escola",
               url: "noticias/Escola",
               defaults: new { controller = "Noticias", action = "Escola", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
