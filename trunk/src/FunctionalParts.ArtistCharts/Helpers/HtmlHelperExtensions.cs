using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace FunctionalParts.ArtistCharts.Helpers
{
	public static class HtmlHelperExtensions
	{
		public static MvcHtmlString ArtistCharts(this HtmlHelper helper)
		{
			return helper.Action("Index", "ArtistCharts", new {area = "artistcharts"});
		}
	}
}