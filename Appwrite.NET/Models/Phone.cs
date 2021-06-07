using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class PhoneCode
	{
		[JsonPropertyName("code")]
		public string Code { get; set; }

		[JsonPropertyName("countryCode")]
		public string CountryCode { get; set; }

		[JsonPropertyName("countryName")]
		public string CountryName { get; set; }
	}

	public class PhoneCodesList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("phones")]
		public List<PhoneCode> Phones { get; set; }
	}
}
