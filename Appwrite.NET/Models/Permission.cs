using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class Permissions
	{
		public List<string> Read { get; set; }
		public List<string> Write { get; set; }
	}
}
