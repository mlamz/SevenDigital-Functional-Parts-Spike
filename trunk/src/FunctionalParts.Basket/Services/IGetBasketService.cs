using System;

namespace FunctionalParts.Basket.Services
{
	public interface IGetBasketService
	{
		SevenDigital.Api.Wrapper.Schema.Basket.Basket GetBasket(Guid basketId);
	}
}