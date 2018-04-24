using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UkAdcHtmlAttributeProvider.Infrastructure;

namespace ToeffToeff
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            HtmlAttributeProvider.Register(metadata => metadata.IsRequired, "aria-required", true);
            HtmlAttributeProvider.Register(metadata => metadata.DataTypeName == "Date", "class", "date");
        }
    }
}
