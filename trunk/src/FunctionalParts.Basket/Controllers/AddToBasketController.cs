using System;
using System.Web.Mvc;
using FunctionalParts.Basket.Services;

namespace FunctionalParts.Basket.Controllers
{
    public class AddToBasketController : Controller
    {
    	private IAddToBasketService _addToBasketService;
    	private ICreateBasketService _createBasketService;

    	public AddToBasketController(IAddToBasketService addToBasketService, ICreateBasketService createBasketService)
    	{
    		_addToBasketService = addToBasketService;
    		_createBasketService = createBasketService;
    	}

    	public ActionResult Index(int releaseId)
        {
        	Guid basketId = GetBasketId();

    		_addToBasketService.AddToBasket(basketId, releaseId);

			return new RedirectResult(Request.UrlReferrer.ToString());
        }

    	private Guid GetBasketId()
    	{
    		if(Session["basketId"] == null)
    		{
    			Session["basketId"] = _createBasketService.CreateBasket();
    		}

    		return (Guid)Session["basketId"];
    	}
    }
}
