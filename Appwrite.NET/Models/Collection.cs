using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Collection
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("$permissions")]
		public Permissions Permissions { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("dateCreated")]
		public int DateCreated { get; set; }

		[JsonPropertyName("dateUpdated")]
		public int DateUpdated { get; set; }

		[JsonPropertyName("rules")]
		public List<Rule> Rules { get; set; }
	}

	public class CollectionsList
	{
		[JsonPropertyName("sum")]
		public int Sume { get; set; }

		[JsonPropertyName("collections")]
		public List<Collection> Collections { get; set; }
	}
}
