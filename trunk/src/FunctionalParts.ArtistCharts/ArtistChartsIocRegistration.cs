using System;
using System.Collections.Generic;
using FunctionalParts.ArtistCharts.Services;
using FunctionalParts.IocRegistrations;

namespace FunctionalParts.ArtistCharts
{
	public class ArtistChartsIocRegistration : IIocRegistration
	{
		public IEnumerable<Tuple<Type, Type>> IocRegistrations
		{
			get
			{
				return new List<Tuple<Type, Type>>
				       	{
				       		new Tuple<Type, Type>(typeof (IArtistChartsService), typeof (ArtistChartsService))
				       	};
			}
		}
	}
}