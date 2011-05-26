using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FunctionalParts.IocRegistrations;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace FunctionalParts.IocBootstrapper
{
	public static class IocRegistries
	{
		private const string FUNCTIONAL_PARTS_ASSEMBLY_PREFIX = "FunctionalParts.";

		public static Action<IInitializationExpression> FunctionalPartsIoc
		{
			get
			{
				return x =>
				       	{
							foreach (var iocRegistration in GetIocRegistrations())
				       		{
								x.AddRegistry(iocRegistration);
				       		}
				       	};
			}
		}

		private static IEnumerable<Registry> GetIocRegistrations()
		{
			IEnumerable<Tuple<Type, Type>> functionalPartsIocRegistrations = GetFunctionalPartsIocRegistrations();

			foreach (var functionalPartsIocRegistration in functionalPartsIocRegistrations)
			{
				Registry registry =  Activator.CreateInstance<Registry>();
				registry.ForRequestedType(functionalPartsIocRegistration.Item1).TheDefaultIsConcreteType(functionalPartsIocRegistration.Item2);
				yield return registry;
			}
		}

		private static IEnumerable<Tuple<Type, Type>> GetFunctionalPartsIocRegistrations()
		{
			IEnumerable<Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.StartsWith(FUNCTIONAL_PARTS_ASSEMBLY_PREFIX));
			
			foreach (var assembly in assemblies)
			{
				Type registryType = GetIocRegistryType(assembly);
				if (registryType != null)
				{
					var instance = (IIocRegistration)Activator.CreateInstance(registryType);
					foreach (Tuple<Type, Type> iocRegistration in instance.IocRegistrations)
					{
						yield return iocRegistration;
					}
				}
			}
		}

		private static Type GetIocRegistryType(Assembly assembly)
		{
			return assembly.GetTypes()
				.SingleOrDefault(x => !x.IsInterface && typeof(IIocRegistration).IsAssignableFrom(x));
		}
	}
}
