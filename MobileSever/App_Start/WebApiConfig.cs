using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace MobileSever
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            //config.EnableCors(new EnableCorsAttribute("http://localhost:51212/","*","*"));
           // config.EnableCors();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }


    }
}
