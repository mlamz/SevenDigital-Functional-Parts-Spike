using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FunctionalParts.IocBootstrapper;

namespace ExampleStore
{
	public class MvcApplication : HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"ReleasePage", 
				"Artist/{artistName}/Release/{releaseTitle}", 
				new { controller = "Release", action = "Index", artistName = UrlParameter.Optional, releaseTitle = UrlParameter.Optional }
			);

			routes.MapRoute(
				"ArtistPage", 
				"Artist/{artistName}", 
				new { controller = "Artist", action = "Index", artistName = UrlParameter.Optional } 
			);

			routes.MapRoute(
				"Default", 
				"{controller}/{action}/{id}", 
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } 
			);

		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			IocBootstrapper.Bootstrap();
			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);
		}
	}
}