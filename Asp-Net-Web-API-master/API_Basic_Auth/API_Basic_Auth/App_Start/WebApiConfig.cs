﻿using API_Basic_Auth.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API_Basic_Auth
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

            config.Filters.Add(new BasicAuthenticationAttribute());
        }
    }
}
