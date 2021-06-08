using Appwrite.NET.Interfaces;
using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Appwrite.NET.Services
{
	public class StorageService: IStorageService
	{
		private AppwriteClient _appwrite;
		private const string basePath = "/storage/files";
		public StorageService(AppwriteClient appwrite)
		{
			_appwrite = appwrite;
		}

		public async Task<FilesList> ListFiles(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "search", search },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderType", orderType.ToString() }
			};

			var response = await _appwrite.CallAsync("GET", basePath, parameters);

			return JsonSerializer.Deserialize<FilesList>(response);
		}
		public async Task<AppwriteFile> CreateFile(FileInfo file, List<string> Read, List<string> Write) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "file", file },
				{ "read", Read },
				{ "write", Write }
			};

			var response = await _appwrite.CallAsync("POST", basePath, parameters);

			return JsonSerializer.Deserialize<AppwriteFile>(response);
		}
		public async Task<AppwriteFile> GetFile(string fileId) {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/{fileId}");

			return JsonSerializer.Deserialize<AppwriteFile>(response);
		}
		public async Task<AppwriteFile> UpdateFile(string FileId, List<string> Read, List<string> Write) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "read", Read },
				{ "write", Write }
			};

			var response = await _appwrite.CallAsync("PUT", $"{basePath}/{FileId}", parameters);
			return JsonSerializer.Deserialize<AppwriteFile>(response);
		}
		public async Task DeleteFile(string fileId) {
			await _appwrite.CallAsync("DELETE", $"{basePath}/{fileId}");
		}
		public string GetFileDownload(string fileId) {
			return $"{_appwrite.GetEndpoint()}/{basePath}/{fileId}/download";
		}
		public string GetFilePreview(string fileId, int? width = 0, int? height = 0, int? quality = 100, string background = "", string output = "") {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "width", width },
				{ "height", height },
				{ "quality", quality },
				{ "background", background },
				{ "output", output },
			};
			return $"{_appwrite.GetEndpoint()}/{basePath}/{fileId}/preview?{parameters.ToQueryString()}";
		}
		public string GetFileView(string fileId) {
			return $"{_appwrite.GetEndpoint()}/{basePath}/{fileId}/view";
		}
	}
}
