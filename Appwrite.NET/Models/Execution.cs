using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Execution
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("functionId")]
		public string FunctionId { get; set; }

		[JsonPropertyName("dateCreated")]
		public int DateCreated { get; set; }

		[JsonPropertyName("trigger")]
		public string Trigger { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("exitCode")]
		public int ExitCode { get; set; }

		[JsonPropertyName("stdout")]
		public string Stdout { get; set; }

		[JsonPropertyName("stderr")]
		public string Stderr { get; set; }

		[JsonPropertyName("time")]
		public int Time { get; set; }
	}

	public class ExecutionsList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("executions")]
		public List<Execution> Executions { get; set; }
	}
}
