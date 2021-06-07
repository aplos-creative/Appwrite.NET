using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Continent
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("code")]
		public string Code { get; set; }
	}

	public class ContinentsList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("continents")]
		public List<Continent> Continents { get; set; }
	}
}

