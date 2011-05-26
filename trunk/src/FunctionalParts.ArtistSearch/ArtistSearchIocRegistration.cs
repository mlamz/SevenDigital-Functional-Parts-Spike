using System;
using System.Collections.Generic;
using FunctionalParts.ArtistSearch.Services;
using FunctionalParts.IocRegistrations;

namespace FunctionalParts.ArtistSearch
{
	public class ArtistSearchIocRegistration : IIocRegistration
	{
		public IEnumerable<Tuple<Type, Type>> IocRegistrations
		{
			get
			{
				return new List<Tuple<Type, Type>>
				       	{
				       		new Tuple<Type, Type>(typeof (IArtistSearchService), typeof (ArtistSearchService))
				       	};
			}
		}
	}
}