using System.Collections.Generic;
using System.Web.Mvc;
using FunctionalParts.ArtistSearch.Services;
using FunctionalParts.ArtistSearch.ViewModels;
using SevenDigital.Api.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistSearch.Controllers
{
	public class ArtistSearchController : Controller
	{
		private IArtistSearchService _artistSearchService;

		public ArtistSearchController(IArtistSearchService artistSearchService)
		{
			_artistSearchService = artistSearchService;
		}

		[ChildActionOnly]
		public ActionResult Index()
		{
			var artistSearchViewModel = TempData["ArtistSearch"] as ArtistSearchViewModel;

			return PartialView(artistSearchViewModel ?? new ArtistSearchViewModel());
		}

		public ActionResult Search(string query)
		{
			IEnumerable<Artist> artists = _artistSearchService.Search(query);

			var artistSearchViewModel = new ArtistSearchViewModel
			                            	{
			                            		Artists = artists ?? new List<Artist>(),
												SearchTerm = query
			                            	};

			TempData["ArtistSearch"] = artistSearchViewModel;

			return new RedirectResult(Request.UrlReferrer.ToString());
		}

	}
}