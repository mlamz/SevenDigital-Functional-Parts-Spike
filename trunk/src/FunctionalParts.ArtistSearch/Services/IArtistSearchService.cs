using System.Collections.Generic;
using SevenDigital.Api.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistSearch.Services
{
	public interface IArtistSearchService
	{
		IEnumerable<Artist> Search(string query);
	}
}