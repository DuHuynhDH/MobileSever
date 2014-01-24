﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MobileSever
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            EnableCrossDomain();
        }

        static void EnableCrossDomain()
        {
            string origin = HttpContext.Current.Request.Headers["Origin"];
            if (string.IsNullOrEmpty(origin)) return;
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", origin);
            string method = HttpContext.Current.Request.Headers["Access-Control-Request-Method"];
            if (!string.IsNullOrEmpty(method))
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", method);
            string headers = HttpContext.Current.Request.Headers["Access-Control-Request-Headers"];
            if (!string.IsNullOrEmpty(headers))
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", headers);
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Credentials", "true");
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.StatusCode = 204;
                HttpContext.Current.Response.End();
            }
        }
    }
}