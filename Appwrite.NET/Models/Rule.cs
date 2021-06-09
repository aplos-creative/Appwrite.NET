using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
    public class Rule
    {
        [JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("$collection")]
		public string Collection { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("key")]
		public string Key { get; set; }

		[JsonPropertyName("label")]
		public string Label { get; set; }

		[JsonPropertyName("default")]
		public string Default { get; set; }

		[JsonPropertyName("array")]
		public bool Array { get; set; }

		[JsonPropertyName("required")]
		public bool Required { get; set; }

		[JsonPropertyName("list")]
		public List<string> List { get; set; }
	}
}
