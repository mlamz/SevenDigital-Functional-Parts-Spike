using System.Web.Mvc;

namespace ExampleStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			return View();
        }

    }
}
