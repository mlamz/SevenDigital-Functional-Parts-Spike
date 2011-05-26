using System.Web.Mvc;
using MvcContrib.PortableAreas;

namespace FunctionalParts.ReleaseDetails
{
	public class ReleaseDetailsAreaRegistration : PortableAreaRegistration
	{
		public override string AreaName
		{
			get { return "releasedetails"; }
		}

		public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
		{
			context.MapRoute(
				"ReleaseDetails",
				"ReleaseDetails",
				new { controller = "releasedetails", action = "index" });

			RegisterAreaEmbeddedResources();
		}
	}
}