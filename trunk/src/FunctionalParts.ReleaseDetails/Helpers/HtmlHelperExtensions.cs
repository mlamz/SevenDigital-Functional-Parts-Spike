using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace FunctionalParts.ReleaseDetails.Helpers
{
	public static class HtmlHelperExtensions
	{
		public static MvcHtmlString ReleaseDetails(this HtmlHelper helper, string artistName, string releaseTitle)
		{
			return helper.Action("Index", "ReleaseDetails", new { area = "releasedetails", artistName = artistName, releaseTitle = releaseTitle });
		}
	}
}