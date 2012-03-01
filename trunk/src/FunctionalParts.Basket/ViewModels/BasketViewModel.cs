using System;

namespace FunctionalParts.Basket.ViewModels
{
	public class BasketViewModel
	{
		public SevenDigital.Api.Schema.Basket.Basket Basket { get; set; }

		public string NoItemsMessage { get; set; }
	}
}