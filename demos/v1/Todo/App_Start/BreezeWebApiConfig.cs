using System.Web.Http;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Todo.App_Start.BreezeWebApiConfig), "RegisterBreezePreStart")]
namespace Todo.App_Start
{
    public static class BreezeWebApiConfig
    {
        public static void RegisterBreezePreStart()
        {
            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
                name: "BreezeApi",
                routeTemplate: "breeze/{controller}/{action}"
                );
        }
    }
}