using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Language
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("code")]
		public string Code { get; set; }

		[JsonPropertyName("nativeName")]
		public string NativeName { get; set; }
	}

	public class LanguagesList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("languages")]
		public List<Language> Languages { get; set; }
	}
}
