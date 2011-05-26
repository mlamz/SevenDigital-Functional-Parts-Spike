using System.Collections.Generic;
using SevenDigital.Api.Wrapper.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistSearch.Services
{
	public interface IArtistSearchService
	{
		IEnumerable<Artist> Search(string query);
	}
}