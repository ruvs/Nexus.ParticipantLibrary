﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Nexus.ParticipantLibrary
{
    public static class WebApiConfig
    {
        public static HttpConfiguration Configure()
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            return config;
        }

        //public static HttpConfiguration Configure(IAmAnEndorsementCatalogLibrary library, IEndorsementCatalogLogger logger)
        //{
        //    var config = new HttpConfiguration();

        //    config.MapHttpAttributeRoutes();

        //    var nanoContainer = new NanoContainer();
        //    nanoContainer.Register(library);
        //    config.Services.Replace(typeof(IHttpControllerActivator), new ManualControllerActivation(nanoContainer));
        //    config.Services.Replace(typeof(IExceptionHandler), new EndorsementCatalogExceptionHandler());
        //    config.Services.Add(typeof(IExceptionLogger), new EndorsementCatalogExceptionLogger(logger));

        //    return config;
        //}

    }
}