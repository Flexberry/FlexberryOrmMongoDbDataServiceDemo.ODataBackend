namespace NewPlatform.FlexberryOrmMongoDbDataServiceDemo
{
    using System;
    using System.Reflection;
    using System.Web.Http;
    using System.Web.Http.Dispatcher;

    using Microsoft.Practices.Unity;

    using ICSSoft.Services;
    using IIS.Caseberry.Logging.Objects;

    using NewPlatform.Flexberry;
    using NewPlatform.Flexberry.AspNet.WebApi.Cors;
    using NewPlatform.Flexberry.ORM.ODataService;
    using NewPlatform.Flexberry.ORM.ODataService.Extensions;
    using NewPlatform.Flexberry.ORM.ODataService.Model;
    using NewPlatform.Flexberry.Services;

    /// <summary>
    /// Configure OData Service.
    /// </summary>
    internal static class ODataConfig
    {
        /// <summary>
        /// Configure OData by DataObjects assembly.
        /// </summary>
        /// <param name="config">Http configuration object.</param>
        /// <param name="container">Unity container.</param>
        public static void Configure(HttpConfiguration config, IUnityContainer container)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            // To support CORS uncomment the line below.
            config.EnableCors(new DynamicCorsPolicyProvider());
            // Use constructor with true first parameter for enable SupportsCredentials.

            // Use Unity as WebAPI dependency resolver
            config.DependencyResolver = new UnityDependencyResolver(container);

            // Map OData Service with all objects
            config.MapODataServiceDataObjectRoute(new DefaultDataObjectEdmModelBuilder(new[]
            {
                Assembly.Load("FlexberryOrmMongoDbDataServiceDemo.Objects"),
                Assembly.Load("EmberFlexberry.Objects"),
                typeof(ApplicationLog).Assembly,
                typeof(UserSetting).Assembly,
                typeof(FlexberryUserSetting).Assembly,
                typeof(Lock).Assembly
            }));

            // Map OData Service only with objects from Ember Flexberry Dummy
            config.MapODataServiceDataObjectRoute(new DefaultDataObjectEdmModelBuilder(new[]
            {
                Assembly.Load("EmberFlexberry.Objects"),
            }), "bypass", "bypass");

            config.Services.Replace(typeof(IHttpControllerActivator), new ControllerActivator(container));
        }
    }
}