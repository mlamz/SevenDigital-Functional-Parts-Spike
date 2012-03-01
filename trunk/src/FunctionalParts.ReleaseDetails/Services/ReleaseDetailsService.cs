using System.Linq;
using SevenDigital.Api.Schema.ReleaseEndpoint;
using SevenDigital.Api.Wrapper;

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
			return releaseSearch.Results != null 
				? releaseSearch.Results.FirstOrDefault(x => x.Release.Artist.Name == artistName).Release 
				?? releaseSearch.Results.FirstOrDefault().Release
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