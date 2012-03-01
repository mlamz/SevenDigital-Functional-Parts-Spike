using System.Configuration;
using SevenDigital.Api.Wrapper;

namespace ExampleStore
{
	public class ApiUri : IApiUri
	{
		public string Uri
		{
			get { return ConfigurationManager.AppSettings["Wrapper.BaseUrl"]; }
		}
	}
}