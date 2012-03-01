using System.Collections.Generic;
using SevenDigital.Api.Schema.ArtistEndpoint;
using SevenDigital.Api.Wrapper;

namespace FunctionalParts.ArtistSearch.Services
{
	public class ArtistSearchService : IArtistSearchService
	{
		public IEnumerable<Artist> Search(string query)
		{
			ArtistBrowse artists = Api<ArtistBrowse>.Get
				.WithLetter(query)
				.Please();

			return artists.Artists;
		}
	}
}