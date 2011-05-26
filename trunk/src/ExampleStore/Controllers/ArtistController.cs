using System.Web.Mvc;
using ExampleStore.ViewModels;

namespace ExampleStore.Controllers
{
    public class ArtistController : Controller
    {
        public ActionResult Index(string artistName)
        {
        	var artistViewModel = new ArtistViewModel
        	                      	{
        	                      		ArtistName = artistName
        	                      	};
			return View(artistViewModel);
        }

    }
}
