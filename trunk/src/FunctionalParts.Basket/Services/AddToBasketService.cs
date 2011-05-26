using System;
using SevenDigital.Api.Wrapper;
using SevenDigital.Api.Wrapper.Schema.Basket;

namespace FunctionalParts.Basket.Services
{
	public class AddToBasketService : IAddToBasketService
	{
		public void AddToBasket(Guid basketId, int releaseId)
		{
			Api<SevenDigital.Api.Wrapper.Schema.Basket.Basket>.Get.AddItem(basketId, releaseId).Please();
		}
	}
}