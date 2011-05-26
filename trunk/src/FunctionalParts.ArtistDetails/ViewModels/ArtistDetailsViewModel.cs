using SevenDigital.Api.Wrapper.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistDetails.ViewModels
{
	public class ArtistDetailsViewModel
	{
		public Artist Artist { get; set; }
		public ArtistReleases ArtistReleases { get; set; }
	}
}