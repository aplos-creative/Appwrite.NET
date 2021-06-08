using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Tag
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("functionId")]
		public string FunctionId { get; set; }

		[JsonPropertyName("dateCreated")]
		public int DateCreated { get; set; }

		[JsonPropertyName("command")]
		public string Command { get; set; }

		[JsonPropertyName("size")]
		public string Size { get; set; }
	}

	public class TagsList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("tags")]
		public List<Tag> Tags { get; set; }
	}
}
