using SevenDigital.Api.Schema.ReleaseEndpoint;

namespace FunctionalParts.ReleaseDetails.Services
{
	public interface IReleaseDetailsService
	{
		Release GetRelease(string artistName, string releaseTitle);
	}
}