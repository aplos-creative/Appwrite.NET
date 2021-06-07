using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class User
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("registration")]
		public int Registration { get; set; }

		[JsonPropertyName("status")]
		public int Status { get; set; }

		[JsonPropertyName("passwordUpdate")]
		public int PasswordUpdate { get; set; }

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("emailVerification")]
		public bool EmailVerification { get; set; }

		[JsonPropertyName("prefs")]
		public object Prefs { get; set; }

	}

	public class UsersList
	{
		[JsonPropertyName("sum")]
		public int Sum { get; set; }

		[JsonPropertyName("users")]
		public List<User> Users { get; set; }

	}
}
