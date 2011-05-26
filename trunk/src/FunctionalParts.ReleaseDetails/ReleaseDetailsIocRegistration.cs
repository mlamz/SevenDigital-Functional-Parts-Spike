using System;
using System.Collections.Generic;
using FunctionalParts.IocRegistrations;
using FunctionalParts.ReleaseDetails.Services;

namespace FunctionalParts.ReleaseDetails
{
	public class ReleaseDetailsIocRegistration : IIocRegistration
	{
		public IEnumerable<Tuple<Type, Type>> IocRegistrations
		{
			get
			{
				return new List<Tuple<Type, Type>>
				       	{
				       		new Tuple<Type, Type>(typeof (IReleaseDetailsService), typeof (ReleaseDetailsService))
				       	};
			}
		}
	}
}