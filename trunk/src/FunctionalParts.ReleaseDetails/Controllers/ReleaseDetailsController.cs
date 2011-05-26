using System.Web.Mvc;
using FunctionalParts.ReleaseDetails.Services;
using FunctionalParts.ReleaseDetails.ViewModels;

namespace FunctionalParts.ReleaseDetails.Controllers
{
    public class ReleaseDetailsController : Controller
    {
    	private IReleaseDetailsService _releaseDetailsService;

    	public ReleaseDetailsController(IReleaseDetailsService releaseDetailsService)
    	{
    		_releaseDetailsService = releaseDetailsService;
    	}

    	public ActionResult Index(string artistName, string releaseTitle)
    	{
    		var release = _releaseDetailsService.GetRelease(artistName, releaseTitle);

    		var viewModel = new ReleaseDetailsViewModel
        	                	{
									Release = release
        	                	};

			return PartialView(viewModel);
        }

    }
}
