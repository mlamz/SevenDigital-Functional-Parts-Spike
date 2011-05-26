using System;
using SevenDigital.Api.Wrapper;
using SevenDigital.Api.Wrapper.Schema.ReleaseEndpoint;
using System.Linq;

namespace FunctionalParts.ReleaseDetails.Services
{
	public class ReleaseDetailsService : IReleaseDetailsService
	{
		public Release GetRelease(string artistName, string releaseTitle)
		{
			ReleaseSearch releaseSearch = GetReleaseTitleMatches(releaseTitle);

			if (releaseSearch != null)
			{
				var releaseFromSearch = GetReleaseFromSearch(releaseSearch, artistName);
				if (releaseFromSearch != null)
				{
					releaseFromSearch.Image = GenerateLargePackshotImage(releaseFromSearch.Image);
				}

				return releaseFromSearch;
			}
			return null;
		}

		private string GenerateLargePackshotImage(string image)
		{
			return image.Replace("_50.jpg", "_350.jpg");
		}

		private Release GetReleaseFromSearch(ReleaseSearch releaseSearch, string artistName)
		{
			return releaseSearch.Results.Releases != null 
				? releaseSearch.Results.Releases.FirstOrDefault(x => x.Artist.Name == artistName) ?? releaseSearch.Results.Releases.FirstOrDefault()
				: null;
		}

		private ReleaseSearch GetReleaseTitleMatches(string releaseTitle)
		{
			return Api<ReleaseSearch>.Get
				.WithParameter("q", releaseTitle)
				.Please();
		}
	}
}