using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Function
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("$permissions")]
		public Permissions Permissions { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("dateCreated")]
		public int DateCreated { get; set; }

		[JsonPropertyName("dateUpdated")]
		public int DateUpdated { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("env")]
		public string Env { get; set; }

		[JsonPropertyName("tag")]
		public string Tag { get; set; }

		[JsonPropertyName("vars")]
		public string Vars { get; set; }

		[JsonPropertyName("events")]
		public List<string> Events { get; set; }

		[JsonPropertyName("schedule")]
		public string Schedule { get; set; }

		[JsonPropertyName("scheduleNext")]
		public int ScheduleNext { get; set; }

		[JsonPropertyName("schedulePrevious")]
		public int SchedulePrevious { get; set; }

		[JsonPropertyName("timeput")]
		public int Timeout { get; set; }
	}

	public class FunctionsList {
		[JsonPropertyName("")]
		public int Sum { get; set; }

		[JsonPropertyName("")]
		public List<Function> Functions { get; set; }
	}
}
