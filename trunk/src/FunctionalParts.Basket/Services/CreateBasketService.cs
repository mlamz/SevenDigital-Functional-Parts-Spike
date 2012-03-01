using System;
using SevenDigital.Api.Wrapper;

namespace FunctionalParts.Basket.Services
{
	public class CreateBasketService : ICreateBasketService
	{
		public Guid CreateBasket()
		{
			var basket = Api<SevenDigital.Api.Schema.Basket.Basket>.Get
				.Create()
				.Please();

			return new Guid(basket.Id);
		}
	}
}