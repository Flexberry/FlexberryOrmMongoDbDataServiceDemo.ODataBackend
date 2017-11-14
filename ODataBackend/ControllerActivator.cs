namespace NewPlatform.FlexberryOrmMongoDbDataServiceDemo
{
    using System;
    using System.Net.Http;
    using System.Web.Http.Controllers;
    using System.Web.Http.Dispatcher;

    using Microsoft.Practices.Unity;

    using ICSSoft.STORMNET.Business;

    using NewPlatform.Flexberry.ORM.ODataService;
    using NewPlatform.Flexberry.ORM.ODataService.Controllers;
    using NewPlatform.Flexberry.ORM.ODataService.Extensions;

    public class ControllerActivator : IHttpControllerActivator
    {
        /// <summary>
        /// <see cref="IUnityContainer"/> for resolve dependenncies.
        /// </summary>
        private readonly IUnityContainer _container;

        /// <summary>
        /// <see cref="IHttpControllerActivator"/> for create controllers other than <see cref="DataObjectController"/>.
        /// </summary>
        private readonly IHttpControllerActivator _defaultActivator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerActivator"/> class.
        /// </summary>
        /// <param name="container"><see cref="IUnityContainer"/> for resolve dependenncies.</param>
        /// <param name="defaultActivator"><see cref="IHttpControllerActivator"/> for create controllers other than <see cref="DataObjectController"/>.</param>
        public ControllerActivator(IUnityContainer container, IHttpControllerActivator defaultActivator = null)
        {
            _container = container;
            _defaultActivator = defaultActivator ?? new DefaultHttpControllerActivator();
        }

        /// <summary>
        /// Based on the <paramref name="request"/>, creates an instance <see cref="DataObjectController"/>, with correct <see cref="IDataService"/>.
        /// </summary>
        /// <param name="request">The request message.</param>
        /// <param name="controllerDescriptor">The controller descriptor.</param>
        /// <param name="controllerType">The type of the controller.</param>
        /// <returns></returns>
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            if (controllerDescriptor.ControllerName == "DataObject")
            {
                ManagementToken token = request.GetODataServiceToken();

                var dataServiceName = string.Empty;
                if (token.Route.RoutePrefix == "bypass")
                    dataServiceName = "MSSQLDataService";
                else
                    switch (request.GetRouteData().Values["odataPath"])
                    {
                        case "Events":
                        case "Cameras":
                        case "RegObjects":
                            dataServiceName = "MongoDbDataService";
                            break;
                        default:
                            dataServiceName = "MSSQLDataService";
                            break;
                    }

                return new DataObjectController(_container.Resolve<IDataService>(dataServiceName), token.Model, token.Events, token.Functions);
            }

            return _defaultActivator.Create(request, controllerDescriptor, controllerType);
        }
    }
}