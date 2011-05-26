using System.Collections.Generic;
using SevenDigital.Api.Wrapper;
using SevenDigital.Api.Wrapper.Schema.ArtistEndpoint;

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