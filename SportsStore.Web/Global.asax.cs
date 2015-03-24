using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.Web
{
    public class MvcApplication : HttpApplication
    {
        #region Protected Methods

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        #endregion Protected Methods
    }
}