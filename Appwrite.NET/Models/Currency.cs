using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Currency
	{
		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("symbolNative")]
		public string SymbolNative { get; set; }

		[JsonPropertyName("decimalDigits")]
		public int DecimalDigits { get; set; }

		[JsonPropertyName("rounding")]
		public int Rounding { get; set; }

		[JsonPropertyName("code")]
		public string Code { get; set; }

		[JsonPropertyName("namePlural")]
		public string NamePlural { get; set; }
	}

	public class CurrenciesList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("currencies")]
		public List<Currency> Currencies { get; set; }
	}
}
