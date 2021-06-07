using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Locale
	{
		[JsonPropertyName("ip")]
		public string IP { get; set; }

		[JsonPropertyName("countryCode")]
		public string CountryCode { get; set; }

		[JsonPropertyName("country")]
		public string Country { get; set; }

		[JsonPropertyName("continentCode")]
		public string ContinentCode { get; set; }

		[JsonPropertyName("eu")]
		public bool EU { get; set; }

		[JsonPropertyName("currency")]
		public string Currency { get; set; }
	}
}
