using System;
using System.Collections.Generic;
using System.Linq;
using FunctionalParts.ArtistCharts.Extensions;
using SevenDigital.Api.Wrapper;
using SevenDigital.Api.Wrapper.Schema;
using SevenDigital.Api.Wrapper.Schema.ArtistEndpoint;
using SevenDigital.Api.Wrapper.Schema.Chart;

namespace FunctionalParts.ArtistCharts.Services
{
	public class ArtistChartsService : IArtistChartsService
	{
		public ArtistChart GetArtistChart(ApiPeriod apiPeriod)
		{
			var artistChart = (ArtistChart)(Api<ArtistChart>
				.Get
				.WithToDate(DateTime.Now.AddMonths(-6))
				.WithPeriod(apiPeriod)
				.WithPageSize(11)
				.Please());

			foreach (var artistChartItem in artistChart.ChartItems)
			{
				artistChartItem.Artist.Image = GetArtistImage(artistChartItem.Artist.Id);
				artistChartItem.Artist.Name = artistChartItem.Artist.UrlEncodedName();
			}
			artistChart.ChartItems = StripVariousArtists(artistChart.ChartItems);

			return artistChart;
		}

		private List<ArtistChartItem> StripVariousArtists(List<ArtistChartItem> artistChartItems)
		{
			return
				artistChartItems
					.Where(x => x.Artist.Name != "Various%20Artists")
					.ToList();
		}

		private string GetArtistImage(int artistId)
		{
			var artist = (Artist)Api<Artist>
				.Get
				.WithArtistId(artistId)
				.Please();
			
			return artist.Image;
		}
	}
}