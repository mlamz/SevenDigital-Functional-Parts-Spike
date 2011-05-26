using System.Web.Mvc;
using MvcContrib.PortableAreas;

namespace FunctionalParts.ArtistCharts
{
	public class ArtistChartsAreaRegistration : PortableAreaRegistration
	{
		public override string AreaName
		{
			get { return "artistcharts"; }
		}

		public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
		{
			context.MapRoute(
				"ArtistCharts",
				"ArtistCharts",
				new { controller = "artistcharts", action = "index" });

			RegisterAreaEmbeddedResources();
		}
	}
}