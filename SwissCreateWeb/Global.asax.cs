using FluentValidation.Mvc;
using SwissCreate.Core.Infrastructure;
using SwissCreateWeb.Framework;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SwissCreateWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //initialize engine context
            EngineContext.Initialize(false);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //fluent validation
            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
            ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(new SwissCreateValidatorFactory()));
        }
    }
}
