using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.AgendamentoAPI
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

            config.Routes.MapHttpRoute(
               name: "ApiByCpf",
               routeTemplate: "api/{controller}/{action}/{cpf}",
               defaults: null,
               constraints: new { cpf = @"^[0-9]+$" }
            );

            config.Routes.MapHttpRoute(
             name: "ApiAction",
             routeTemplate: "api/{controller}/{action}",
             defaults: null
          );

        }
    }
}
