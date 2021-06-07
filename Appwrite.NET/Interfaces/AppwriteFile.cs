using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public class AppwriteFile
	{
		public string ID { get; set; }
		public Permissions Permissions { get; set; }
		public string Name { get; set; }
		public int DateCreate { get; set; }
		public string Signature { get; set; }
		public string MimeType { get; set; }
		public int SizeOriginal { get; set; }
	}

	public class FilesList
	{
		public int Sum { get; set; }
		public List<AppwriteFile> Files { get; set; }
	}

	public class AppwriteFileCreateDTO
	{
		public FileInfo	File { get; set; }
		public Permissions Permissions { get; set; }
	}

	public class AppwriteFileUpdateDTO
	{
		public string FileID { get; set; }
		public Permissions Permissions { get; set; }
	}
}
