using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface IStorageService
	{
		Task<FilesList> ListFiles(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<AppwriteFile> CreateFile(FileInfo file, List<string> Read, List<string> Write);
		Task<AppwriteFile> GetFile(string fileId);
		Task<AppwriteFile> UpdateFile(string FileId, List<string> Read, List<string> Write);
		Task DeleteFile(string fileId);
		string GetFileDownload(string fileId);
		string GetFilePreview(string fileId, int? width = 0, int? height = 0, int? quality = 100, string background = "", string output = "");
		string GetFileView(string fileId);
	}
}
