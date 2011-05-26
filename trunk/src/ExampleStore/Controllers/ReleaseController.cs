using System.Web.Mvc;
using ExampleStore.ViewModels;

namespace ExampleStore.Controllers
{
    public class ReleaseController : Controller
    {
        public ActionResult Index(string artistName, string releaseTitle)
        {
        	var viewModel = new ReleaseViewModel
        	                	{
        	                		ArtistName = artistName,
        	                		ReleaseTitle = releaseTitle
        	                	};
			return View(viewModel);
        }

    }
}
