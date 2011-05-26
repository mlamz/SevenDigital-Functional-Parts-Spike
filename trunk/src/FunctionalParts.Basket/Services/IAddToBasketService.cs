using System;

namespace FunctionalParts.Basket.Services
{
	public interface IAddToBasketService
	{
		void AddToBasket(Guid basketId, int releaseId);
	}
}