using System.Web.Mvc;
using MvcContrib.PortableAreas;

namespace FunctionalParts.Basket
{
	public class BasketAreaRegistration : PortableAreaRegistration
	{
		public override string AreaName
		{
			get { return "basket"; }
		}

		public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
		{
			context.MapRoute(
				"AddToBasket",
				"AddToBasket",
				new { controller = "addtobasket", action = "index", releaseId = UrlParameter.Optional });

			context.MapRoute(
				"Basket",
				"Basket",
				new { controller = "basket", action = "index" });

			RegisterAreaEmbeddedResources();
		}
	}
}