using System;
using System.Collections.Generic;
using FunctionalParts.ArtistDetails.Services;
using FunctionalParts.IocRegistrations;

namespace FunctionalParts.ArtistDetails
{
	public class ArtistDetailsIocRegistration : IIocRegistration
	{
		public IEnumerable<Tuple<Type, Type>> IocRegistrations
		{
			get
			{
				return new List<Tuple<Type, Type>>
				       	{
				       		new Tuple<Type, Type>(typeof (IArtistDetailsService), typeof (ArtistDetailsService))
				       	};
			}
		}
	}
}