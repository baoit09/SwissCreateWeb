using SwissCreateWeb.Framework.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SwissCreateWeb.Framework.Localization;

namespace SwissCreateWeb.Infrastructure
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(System.Web.Routing.RouteCollection routes)
        {
            //We reordered our routes so the most used ones are on top. It can improve performance.

            //home page
            routes.MapLocalizedRoute("HomePage",
                            "",
                            new { controller = "Home", action = "Index" },
                            new[] { "SwissCreateWeb.Controllers" });

            //change language (AJAX link)
            routes.MapLocalizedRoute("ChangeLanguage",
                            "changelanguage/{langid}",
                            new { controller = "Common", action = "SetLanguage" },
                            new { langid = @"\d+" },
                            new[] { "SwissCreateWeb.Controllers" });
        }

        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}