using SevenDigital.Api.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistCharts.Services
{
	public interface IArtistChartsService
	{
		ArtistChart GetArtistChart(string apiPeriod);
	}
}