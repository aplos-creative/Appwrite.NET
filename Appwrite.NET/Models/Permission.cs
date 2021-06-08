using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Permissions
	{
		[JsonPropertyName("read")]
		public List<string> Read { get; set; }

		[JsonPropertyName("write")]
		public List<string> Write { get; set; }
	}
}
