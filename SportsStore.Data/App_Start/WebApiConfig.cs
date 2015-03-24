using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using System.Web.Http;

namespace SportsStore.Data
{
    public static class WebApiConfig
    {
        #region Public Methods

        public static void Register(HttpConfiguration config)
        {
            var jsonFormatter = config.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        #endregion Public Methods
    }
}