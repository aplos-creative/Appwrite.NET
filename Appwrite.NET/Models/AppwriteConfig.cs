using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class AppwriteConfig
	{
		public string ProjectId { get; set; }
		public string Endpoint { get; set; }
		public string Key { get; set; }
		public bool? SelfSigned { get; set; }

		public Uri EndpointUri()
		{
			// This ensures end of endpoint has a / to prevent URI in httpclient from converting v1 to abosolute path
			return new Uri($"{(Endpoint.EndsWith("/") ? Endpoint.Substring(0, Endpoint.Length - 1) : Endpoint)}");
		}
	}
}
