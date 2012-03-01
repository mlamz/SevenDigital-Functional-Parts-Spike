using System.Configuration;
using SevenDigital.Api.Wrapper;

namespace ExampleStore
{
	public class OAuthCredentials : IOAuthCredentials
	{
		public string ConsumerKey
		{
			get { return ConfigurationManager.AppSettings["Wrapper.ConsumerKey"]; }
		}

		public string ConsumerSecret
		{
			get { return ConfigurationManager.AppSettings["Wrapper.ConsumerSecret"]; }
		}
	}
}