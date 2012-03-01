using System;
using SevenDigital.Api.Wrapper;

namespace FunctionalParts.Basket.Services
{
	public class GetBasketService : IGetBasketService
	{
		public SevenDigital.Api.Schema.Basket.Basket GetBasket(Guid basketId)
		{
			return Api<SevenDigital.Api.Schema.Basket.Basket>.Get
				.WithParameter("basketId", basketId.ToString())
				.Please();
		}
	}
}