using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Membership
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("userId")]
		public string UserId { get; set; }

		[JsonPropertyName("teamId")]
		public string TeamId { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("invited")]
		public int Invited { get; set; }

		[JsonPropertyName("joined")]
		public string Joined { get; set; }

		[JsonPropertyName("confirm")]
		public bool Confirm{ get; set; }

		[JsonPropertyName("roles")]
		public List<string> Roles { get; set; }
	}

	public class  MembershipsList
	{
		public int Sum { get; set; }
		public List<Membership> Memberships { get; set; }
	}

	public class MembershipCreateDTO
	{
		public string TeamId { get; set; }
		public string Email { get; set; }
		public List<string> Roles { get; set; }
		public string Url { get; set; }
		public string Name { get; set; }
	}

}
