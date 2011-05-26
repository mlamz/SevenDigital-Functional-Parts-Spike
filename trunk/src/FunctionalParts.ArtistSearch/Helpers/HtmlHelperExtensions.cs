using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace FunctionalParts.ArtistSearch.Helpers
{
	public static class HtmlHelperExtensions
	{
		public static MvcHtmlString ArtistSearch(this HtmlHelper helper)
		{
			return helper.Action("Index", "ArtistSearch", new {area = "artistsearch"});
		}
	}
}