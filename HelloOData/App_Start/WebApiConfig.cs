using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using HelloOData.Models;
using HelloOData.Projections;

namespace HelloOData
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataModelBuilder builder = new ODataConventionModelBuilder();

            config.Count().Filter().OrderBy().Expand().Select().MaxTop(100);

            builder.EntitySet<Person>("People");
            builder.EntitySet<PersonSimple>("SimplePeople");

            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
