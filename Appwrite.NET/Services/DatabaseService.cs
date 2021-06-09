using Appwrite.NET.Interfaces;
using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Appwrite.NET.Services
{
	public class DatabaseService: IDatabaseService
	{
		private AppwriteClient _appwrite;
		private const string basePath = "/database";
		public DatabaseService(AppwriteClient appwrite)
		{
			_appwrite = appwrite;
		}

		public async Task<CollectionsList> ListCollections(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "search", search },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderType", orderType.ToString() }
			};


			var response = await _appwrite.CallAsync("GET", $"{basePath}/collections", parameters);
			return JsonSerializer.Deserialize<CollectionsList>(response);
		}
		public async Task<Collection> CreateCollection(string name, List<object> read, List<object> write, List<object> rules) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "name", name },
				{ "read", read },
				{ "write", write },
				{ "rules", rules }
			};

			var response = await _appwrite.CallAsync("POST", $"{basePath}/collections", parameters);
			return JsonSerializer.Deserialize<Collection>(response);
		}
		public async Task<Collection> GetCollection(string collectionId) {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/collections/{collectionId}");
			return JsonSerializer.Deserialize<Collection>(response);
		}
		public async Task<Collection> UpdateCollection(string collectionId, string name, List<object> read, List<object> write, List<object> rules = null) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "name", name },
				{ "read", read },
				{ "write", write },
				{ "rules", rules }
			};

			var response = await _appwrite.CallAsync("PUT", $"{basePath}/collections", parameters);
			return JsonSerializer.Deserialize<Collection>(response);
		}
		public async Task DeleteCollection(string collectionId) {
			await _appwrite.CallAsync("DELETE", $"{basePath}/collections/{collectionId}");
		}
		public async Task<DocumentsList> ListDocuments(string collectionId, List<object> filters = null, int? limit = 25, int? offset = 0, string orderField = "", OrderType orderType = OrderType.ASC, string orderCast = "string", string search = "") {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "filters", filters },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderField", orderField },
				{ "orderType", orderType.ToString() },
				{ "orderCast", orderCast },
				{ "search", search }
			};

			var response = await _appwrite.CallAsync("GET", $"{basePath}/collections/{collectionId}/documents", parameters);
			return JsonSerializer.Deserialize<DocumentsList>(response);
		}
		public async Task<Document> CreateDocument(string collectionId, object data, List<object> read, List<object> write, string parentDocument = "", string parentProperty = "", string parentPropertyType = "assign") {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "data", data },
				{ "read", read },
				{ "write", write },
				{ "parentDocument", parentDocument },
				{ "parentProperty", parentProperty },
				{ "parentPropertyType", parentPropertyType }
			};

			var response = await _appwrite.CallAsync("POST", $"{basePath}/collections/{collectionId}/documents", parameters);
			return JsonSerializer.Deserialize<Document>(response);
		}
		public async Task<Document> GetDocument(string collectionId, string documentId) {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/collections/{collectionId}/documents/{documentId}");
			return JsonSerializer.Deserialize<Document>(response);
		}
		public async Task<Document> UpdateDocument(string collectionId, string documentId, object data, List<object> read, List<object> write) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "data", data },
				{ "read", read },
				{ "write", write }
			};

			var response = await _appwrite.CallAsync("PUT", $"{basePath}/collections/{collectionId}/documents/{documentId}", parameters);
			return JsonSerializer.Deserialize<Document>(response);
		}
		public async Task DeleteDocument(string collectionId, string documentId) {
			await _appwrite.CallAsync("DELETE", $"{basePath}/collections/{collectionId}/documents/{documentId}");
		}
	}
}
