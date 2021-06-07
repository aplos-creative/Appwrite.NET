using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Appwrite.NET.Models
{
	public class AppwriteFile
	{
		[JsonPropertyName("$id")]
		public string ID { get; set; }

		[JsonPropertyName("$permissions")]
		public Permissions Permissions { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("dateCreated")]
		public int DateCreated { get; set; }

		[JsonPropertyName("signature")]
		public string Signature { get; set; }

		[JsonPropertyName("mimeType")]
		public string MimeType { get; set; }

		[JsonPropertyName("sizeOriginal")]
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
		public List<string> Read { get; set; }
		public List<string> Write { get; set; }
	}

	public class AppwriteFileUpdateDTO
	{
		public string FileID { get; set; }
		public List<string> Read { get; set; }
		public List<string> Write { get; set; }
	}
}
