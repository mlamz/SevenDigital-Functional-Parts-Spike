using System;
using System.Collections.Generic;
using FunctionalParts.Basket.Services;
using FunctionalParts.IocRegistrations;

namespace FunctionalParts.Basket
{
	public class BasketIocRegistration : IIocRegistration
	{
		public IEnumerable<Tuple<Type, Type>> IocRegistrations
		{
			get
			{
				return new List<Tuple<Type, Type>>
				       	{
				       		new Tuple<Type, Type>(typeof (ICreateBasketService), typeof (CreateBasketService)),
				       		new Tuple<Type, Type>(typeof (IAddToBasketService), typeof (AddToBasketService)),
				       		new Tuple<Type, Type>(typeof (IGetBasketService), typeof (GetBasketService)),
				       	};
			}
		}
	}
}