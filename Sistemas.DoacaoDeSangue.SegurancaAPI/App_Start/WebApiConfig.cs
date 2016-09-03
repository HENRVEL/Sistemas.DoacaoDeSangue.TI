using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Sistemas.DoacaoDeSangue.SegurancaAPI
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
                    //routeTemplate: "api/{controller}/{usuario}/{tipoUsuario}/{senha}",
                    routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "ApiValidacaoSenha",
            routeTemplate: "api/{controller}/{usuario}/{tipoUsuario}/{senha}",
            defaults: null
         );
        }
    }
}
