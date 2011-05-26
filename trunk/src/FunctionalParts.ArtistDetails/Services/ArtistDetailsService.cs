using System.Linq;
using System.Web;
using SevenDigital.Api.Wrapper;
using SevenDigital.Api.Wrapper.Schema.ArtistEndpoint;

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

			return artists.Results.Artists.FirstOrDefault(x => x.Name == artistName);
		}

		public ArtistReleases GetArtistReleases(int artistId)
		{
			return Api<ArtistReleases>.Get
				.WithParameter("artistId", artistId.ToString())
				.Please();
		}
	}
}