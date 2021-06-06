using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Team
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("dateCreated")]
		public int DateCreated { get; set; } // TODO: Parse to datetime

		[JsonPropertyName("sum")]
		public int Sum { get; set; }
	}

	public class TeamCreateDTO {
		public string Name { get; set; }
		public List<string> Roles { get; set; }
	}

	public class TeamsList
	{
		public int Sum { get; set; }
		public List<Team> Teams { get; set; }
	}
}
