using System;
using System.Collections.Generic;
using SevenDigital.Api.Wrapper.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistSearch.ViewModels
{
	public class ArtistSearchViewModel
	{
		public ArtistSearchViewModel()
		{
			Artists = new List<Artist>();
		}

		public string Heading { get; set; }

		public IEnumerable<Artist> Artists { get; set; }

		public string SearchTerm { get; set; }
	}
}
