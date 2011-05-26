using System.Web.Mvc;
using MvcContrib.PortableAreas;

namespace FunctionalParts.ArtistDetails
{
	public class ArtistDetailsAreaRegistration : PortableAreaRegistration
	{
		public override string AreaName
		{
			get { return "artistdetails"; }
		}

		public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
		{
			context.MapRoute(
				"ArtistDetails",
				"ArtistDetails/Index/{artistName}",
				new { controller = "artistdetails", action = "index", artistName = "" });

			RegisterAreaEmbeddedResources();
		}
	}
}