using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace FunctionalParts.ArtistDetails.Helpers
{
	public static class HtmlHelperExtensions
	{
		public static MvcHtmlString ArtistDetails(this HtmlHelper helper, string artistname)
		{
			return helper.Action("Index", "ArtistDetails", new {area = "artistdetails", artistname = artistname});
		}
	}
}