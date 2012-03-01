using System;

namespace FunctionalParts.Basket.Services
{
	public interface IGetBasketService
	{
		SevenDigital.Api.Schema.Basket.Basket GetBasket(Guid basketId);
	}
}