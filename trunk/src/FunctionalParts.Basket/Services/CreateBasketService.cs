using System;
using SevenDigital.Api.Wrapper;
using SevenDigital.Api.Wrapper.Schema.Basket;

namespace FunctionalParts.Basket.Services
{
	public class CreateBasketService : ICreateBasketService
	{
		public Guid CreateBasket()
		{
			var basket = Api<SevenDigital.Api.Wrapper.Schema.Basket.Basket>.Get
				.Create()
				.Please();

			return new Guid(basket.Id);
		}
	}
}