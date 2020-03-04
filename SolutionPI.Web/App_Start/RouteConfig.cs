using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SolutionPI.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contrats",
                url: "{Contrats}/{MyContrat}/{idClient}/{idAnnonce}",
                defaults: new { controller = "Contrats", action = "MyContrat", idClient = 0, idAnnonce = 0 });

            routes.MapRoute(
                name: "ContratsUpdate",
                url: "{Contrats}/{EditContrat}/{idClient}/{idAnnonce}",
                defaults: new { controller = "Contrats", action = "EditContrat", idClient = 0, idAnnonce = 0 });
    
            routes.MapRoute(
                name: "DelContrat",
                url: "{Contrats}/{DelContrat}/{idClient}/{idAnnonce}",
                defaults: new { controller = "Contrats", action = "DelContrat", idClient = 0, idAnnonce = 0 });


        }
    }
}
