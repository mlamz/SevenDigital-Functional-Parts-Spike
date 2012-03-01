using System;
using System.Web.Mvc;
using FunctionalParts.Basket.Services;
using FunctionalParts.Basket.ViewModels;

namespace FunctionalParts.Basket.Controllers
{
	public class BasketController : Controller
	{
		private IGetBasketService _getBasketService;
		private ICreateBasketService _createBasketService;

		public BasketController(IGetBasketService getBasketService, ICreateBasketService createBasketService)
		{
			_getBasketService = getBasketService;
			_createBasketService = createBasketService;
		}

		public ActionResult Index()
		{
			Guid basketId = GetBasketId();

			var basket = _getBasketService.GetBasket(basketId);

			string noItemsMessage = GetNoItemsMessage(basket);

			return PartialView(new BasketViewModel {Basket = basket, NoItemsMessage = noItemsMessage});
		}

		private string GetNoItemsMessage(SevenDigital.Api.Schema.Basket.Basket basket)
		{
			string noItems = "Buy something...";

			return (basket != null)
			       	? (basket.BasketItems.Items.Count > 0) ? string.Empty : noItems
			       	: noItems;
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