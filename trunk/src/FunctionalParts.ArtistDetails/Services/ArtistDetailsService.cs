using System.Linq;
using System.Web;
using SevenDigital.Api.Schema.ArtistEndpoint;
using SevenDigital.Api.Wrapper;

namespace FunctionalParts.ArtistDetails.Services
{
	public class ArtistDetailsService : IArtistDetailsService
	{
		public Artist GetArtist(string artistName)
		{
			artistName = HttpUtility.UrlDecode(artistName);

			var artists = Api<ArtistSearch>.Get
				.WithQuery(HttpUtility.UrlDecode(artistName))
				.Please();

			return artists.Results.FirstOrDefault(x => x.Artist.Name == artistName).Artist;
		}

		public ArtistReleases GetArtistReleases(int artistId)
		{
			return Api<ArtistReleases>.Get
				.WithParameter("artistId", artistId.ToString())
				.Please();
		}
	}
}