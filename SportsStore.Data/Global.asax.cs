using System.Web;
using System.Web.Http;

namespace SportsStore.Data
{
    public class WebApiApplication : HttpApplication
    {
        #region Protected Methods

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        #endregion Protected Methods
    }
}