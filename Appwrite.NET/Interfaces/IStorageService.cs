using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface IStorageService
	{
		Task<List<AppwriteFile>> ListFiles(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<AppwriteFile> CreateFile(AppwriteFileCreateDTO file);
		Task<AppwriteFile> GetFile(string fileId);
		Task<AppwriteFile> UpdateFile(AppwriteFileUpdateDTO file);
		Task DeleteFile(string fileId);
		string GetFileDownload(string fileId);
		string GetFilePreview(string fileId, int? width = 0, int? height = 0, int? quality = 100, string background = "", string output = "");
		string GetFileView(string fileId);
	}
}
