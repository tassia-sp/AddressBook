
using MyWebApp.Core.UnityResolver.cs;
using MyWebApp.Services;
using System.Web.Http;
using System.Web.Mvc;


namespace MyWebApp.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents(HttpConfiguration config)
        {
            //UnityContainer container = new UnityContainer();

            //// register all your components with the container here
            //// it is NOT necessary to register your controllers

            //// e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IPeopleService, PeopleService>();

            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            ////  this line is needed so that the resolver can be used by api controllers 
            //config.DependencyResolver = new UnityResolver(container);
        }
    }
}