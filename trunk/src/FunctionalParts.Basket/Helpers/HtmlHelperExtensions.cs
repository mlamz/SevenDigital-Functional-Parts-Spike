using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace FunctionalParts.Basket.Helpers
{
	public static class HtmlHelperExtensions
	{
		public static MvcHtmlString Basket(this HtmlHelper helper)
		{
			return helper.Action("Index", "Basket", new { area = "basket" });
		}
	}
}