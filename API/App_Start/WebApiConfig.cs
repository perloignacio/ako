using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Configuration;
using API.Clases;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            var cors = new EnableCorsAttribute(ConfigurationManager.AppSettings["urlFront"], "*", "*") { SupportsCredentials = true };
            config.EnableCors(cors);

            // Rutas de API web
            config.MapHttpAttributeRoutes();
            config.MessageHandlers.Add(new TokenValidationHandler());
            config.Filters.Add(new AuthorizationFilter());
        }
    }
}
