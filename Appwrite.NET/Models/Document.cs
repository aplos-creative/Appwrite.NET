using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Document
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("$collection")]
		public string Collection { get; set; }

		[JsonPropertyName("$permissions")]
		public Permissions Permissions { get; set; }
	}

	public class DocumentsList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("documents")]
		public List<Document> Documents { get; set; }
	}
}
