using System.Linq;
using System.Web.Mvc;
using StructureMap;

namespace FunctionalParts.IocBootstrapper
{
	public static class IocBootstrapper
	{
		public static void Bootstrap()
		{
			ObjectFactory.Initialize(IocRegistries.FunctionalPartsIoc);

			SetDependencyResolver();
		}

		private static void SetDependencyResolver()
		{
			DependencyResolver.SetResolver(
				t =>
					{
						try
						{
							return ObjectFactory.GetInstance(t);
						}
						catch
						{
							return null;
						}
					},
				t => ObjectFactory.GetAllInstances<object>().Where(s => s.GetType() == t)
				);
		}
	}
}