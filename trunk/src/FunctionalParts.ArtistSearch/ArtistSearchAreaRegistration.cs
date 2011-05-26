using System.Web.Mvc;
using MvcContrib.PortableAreas;

namespace FunctionalParts.ArtistSearch
{
	public class ArtistSearchAreaRegistration : PortableAreaRegistration
	{
		public override string AreaName
		{
			get { return "artistsearch"; }
		}

		public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
		{
			context.MapRoute(
				"ArtistSearch",
				"ArtistSearch",
				new { controller = "artistsearch", action = "index", query = "" });

			context.MapRoute(
				"ArtistSearchQuery",
				"ArtistSearch/Search",
				new { controller = "artistsearch", action = "search" });

			RegisterAreaEmbeddedResources();
		}
	}
}