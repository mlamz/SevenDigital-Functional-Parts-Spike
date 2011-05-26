using SevenDigital.Api.Wrapper.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistCharts.Services
{
	public interface IArtistChartsService
	{
		ArtistChart GetArtistChart(ApiPeriod apiPeriod);
	}
}