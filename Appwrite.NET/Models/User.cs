using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class User
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public int Registration { get; set; }
		public int Status { get; set; }
		public int PasswordUpdate { get; set; }
		public string Email { get; set; }
		public bool EmailVerification { get; set; }
		public object Prefs { get; set; }
	}

	public class UserCreateDTO
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
	}
}
