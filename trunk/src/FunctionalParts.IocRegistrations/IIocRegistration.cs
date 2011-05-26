using System;
using System.Collections.Generic;

namespace FunctionalParts.IocRegistrations
{
	public interface IIocRegistration
	{
		IEnumerable<Tuple<Type, Type>> IocRegistrations { get; } 
	}
}