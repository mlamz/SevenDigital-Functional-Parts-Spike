using System.Web;
using System.Web.Mvc;
using FunctionalParts.ArtistDetails.Services;
using FunctionalParts.ArtistDetails.ViewModels;

namespace FunctionalParts.ArtistDetails.Controllers
{
	public class ArtistDetailsController: Controller
	{
		private IArtistDetailsService _artistDetailsService;

		public ArtistDetailsController(IArtistDetailsService artistDetailsService)
		{
			_artistDetailsService = artistDetailsService;
		}

		[ChildActionOnly]
		public ActionResult Index(string artistName)
		{
			var artist = _artistDetailsService.GetArtist(artistName);

			var artistReleases = (artist != null) 
									? _artistDetailsService.GetArtistReleases(artist.Id) 
									: null;

			return PartialView(new ArtistDetailsViewModel
			                   	{
			                   		Artist = artist,
									ArtistReleases = artistReleases
			                   	});
		}
	}
}