﻿namespace NewPlatform.FlexberryOrmMongoDbDataServiceDemo
{
    using System;
    using System.Web;
    using System.Web.Http;

    using ICSSoft.STORMNET.Business;

    using Microsoft.Practices.Unity;
    using Microsoft.Practices.Unity.Configuration;

    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();
            GlobalConfiguration.Configure(configuration => ODataConfig.Configure(configuration, container));
        }
    }
}
