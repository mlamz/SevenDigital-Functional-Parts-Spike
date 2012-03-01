using System.Web;
using SevenDigital.Api.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistCharts.Extensions
{
	public static class ArtistExtensions
	{
		public static string UrlEncodedName(this Artist artist)
		{
			return HttpUtility.UrlPathEncode(artist.Name);
		}
	}
}