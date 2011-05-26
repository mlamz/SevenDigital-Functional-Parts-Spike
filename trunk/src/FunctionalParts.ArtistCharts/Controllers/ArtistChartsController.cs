using System;
using System.Web.Mvc;
using FunctionalParts.ArtistCharts.Services;
using FunctionalParts.ArtistCharts.ViewModel;
using SevenDigital.Api.Wrapper.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistCharts.Controllers
{
    public class ArtistChartsController : Controller
    {
    	private IArtistChartsService _artistChartsService;

    	public ArtistChartsController(IArtistChartsService artistChartsService)
    	{
    		_artistChartsService = artistChartsService;
    	}

    	public ActionResult Index()
    	{
    		var artistChart = _artistChartsService.GetArtistChart(ApiPeriod.Week);

			return View(new ArtistChartsViewModel{ ArtistChart = artistChart });
        }

    }
}
