using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Country
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("code")]
		public string Code { get; set; }
	}

	public class CountriesList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("countries")]
		public List<Country> Countries { get; set; }
	}
}
