using SwissCreate.Core.Infrastructure;
using SwissCreate.Services.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SwissCreateWeb.CustomAttributes
{
    public class HasPermission_AuthorizeFilter : AuthorizeAttribute
    {
        public string SystemName { get; set; }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var _permissionService = EngineContext.Current.Resolve<IPermissionService>();

            if (_permissionService.Authorize(SystemName))
            {
                base.OnAuthorization(filterContext);
            }
            else
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    JsonResult result = new JsonResult()
                    {
                        Data = new { Result = "ERROR", Message = "You do not have a permission to access to this function. Please contact the admin." }
                    };

                    filterContext.Result = result;
                    return;
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { controller = "Error", action = "ShowError", errorMsg = "You do not have a permission to access to this function. Please contact the admin." }));
                }
            }
        }
    }
}