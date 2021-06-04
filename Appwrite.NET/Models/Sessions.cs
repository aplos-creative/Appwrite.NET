using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Session: LogBase
	{
		[JsonPropertyName("id")]
		public string ID { get; set; }

		[JsonPropertyName("userId")]
		public string UserId { get; set; }

		[JsonPropertyName("expire")]
		public int Expire { get; set; }

		[JsonPropertyName("provider")]
		public string Provider { get; set; }

		[JsonPropertyName("providerUid")]
		public string ProviderUid { get; set; }

		[JsonPropertyName("providerToken")]
		public string ProviderToken { get; set; }

		[JsonPropertyName("current")]
		public bool Current { get; set; }
	}

	public class SessionsList
	{
		[JsonPropertyName("sum")]
		public int Sum{ get; set; }

		[JsonPropertyName("sessions")]
		public List<Session> Sessions { get; set; }
	}
}
