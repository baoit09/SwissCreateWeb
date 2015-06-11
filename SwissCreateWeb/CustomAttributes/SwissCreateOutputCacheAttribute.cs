using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwissCreateWeb.CustomAttributes
{
    public class SwissCreateOutputCacheAttribute : OutputCacheAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // TODO: extract the domain from filterContext.HttpContext.Request.Url
            // and set the duration accordingly

            Duration = 60;

            base.OnResultExecuting(filterContext);
        }
    }
}