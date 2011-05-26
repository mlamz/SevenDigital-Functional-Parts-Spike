using System;
using SevenDigital.Api.Wrapper;

namespace FunctionalParts.Basket.Services
{
	public class GetBasketService : IGetBasketService
	{
		public SevenDigital.Api.Wrapper.Schema.Basket.Basket GetBasket(Guid basketId)
		{
			return Api<SevenDigital.Api.Wrapper.Schema.Basket.Basket>.Get
				.WithParameter("basketId", basketId.ToString())
				.Please();
		}
	}
}