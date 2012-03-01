using System;
using SevenDigital.Api.Wrapper;

namespace FunctionalParts.Basket.Services
{
	public class AddToBasketService : IAddToBasketService
	{
		public void AddToBasket(Guid basketId, int releaseId)
		{
			Api<SevenDigital.Api.Schema.Basket.Basket>.Get.AddItem(basketId, releaseId).Please();
		}
	}
}