using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{

	public class LogsList
	{
		[JsonPropertyName("logs")]
		public List<Log> Logs { get; set; }
	}

	public class LogBase
	{
		[JsonPropertyName("ip")]
		public string IP { get; set; }

		[JsonPropertyName("osCode")]
		public string OSCode { get; set; }

		[JsonPropertyName("osName")]
		public string OSName { get; set; }

		[JsonPropertyName("osVersion")]
		public string OSVersion { get; set; }

		[JsonPropertyName("clientType")]
		public string ClientType { get; set; }

		[JsonPropertyName("clientCode")]
		public string ClientCode { get; set; }

		[JsonPropertyName("clientName")]
		public string ClientName { get; set; }

		[JsonPropertyName("clientVersion")]
		public string ClientVersion { get; set; }

		[JsonPropertyName("clientEngine")]
		public string ClientEngine { get; set; }

		[JsonPropertyName("clientEngineVersion")]
		public string ClientEngineVersion { get; set; }

		[JsonPropertyName("deviceName")]
		public string DeviceName { get; set; }

		[JsonPropertyName("deviceBrand")]
		public string DeviceBrand { get; set; }

		[JsonPropertyName("deviceModel")]
		public string DeviceModel { get; set; }

		[JsonPropertyName("countryCode")]
		public string CountryCode { get; set; }

		[JsonPropertyName("countryName")]
		public string CountryName { get; set; }
	}

	public class Log: LogBase
	{
		[JsonPropertyName("event")]
		public string Event { get; set; }

		[JsonPropertyName("time")]
		public int Time { get; set; }
	}
}
