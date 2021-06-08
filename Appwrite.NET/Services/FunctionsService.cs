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
	public class FunctionsService: IFunctionsService
	{
		private AppwriteClient _appwrite;
		private const string basePath = "/functions";
		public FunctionsService(AppwriteClient appwrite)
		{
			_appwrite = appwrite;
		}

		public async Task<FunctionsList> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "search", search },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderType", orderType.ToString() }
			};

			var response = await _appwrite.CallAsync("GET", basePath, parameters);

			return JsonSerializer.Deserialize<FunctionsList>(response);
		}

		public async Task<Function> Create(string name, List<object> execute, string env, object vars = null, List<object> events = null, string schedule = "", int? timeout = 15)
		{
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "name", name },
				{ "execute", execute },
				{ "env", env },
				{ "vars", vars },
				{ "events", events },
				{ "schedule", schedule },
				{ "timeout", timeout }
			};

			var response = await _appwrite.CallAsync("POST", basePath, parameters);
			return JsonSerializer.Deserialize<Function>(response);
		}

		public async Task<Function> Get(string functionId)
		{
			var response = await _appwrite.CallAsync("GET", $"{basePath}/{functionId}");
			return JsonSerializer.Deserialize<Function>(response);
		}

		public async Task<Function> Update(string functionId, string name, List<object> execute, object vars = null, List<object> events = null, string schedule = "", int? timeout = 15)
		{
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "name", name },
				{ "execute", execute },
				{ "vars", vars },
				{ "events", events },
				{ "schedule", schedule },
				{ "timeout", timeout }
			};

			var response = await _appwrite.CallAsync("PUT", basePath, parameters);
			return JsonSerializer.Deserialize<Function>(response);
		}

		public async Task Delete(string functionId)
		{
			await _appwrite.CallAsync("DELETE", $"{basePath}/{functionId}");
		}
		public async Task<ExecutionsList> ListExecutions(string functionId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC)
		{
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "search", search },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderType", orderType.ToString() }
			};

			var response = await _appwrite.CallAsync("GET", basePath, parameters);
			return JsonSerializer.Deserialize<ExecutionsList>(response);
		}

		public async Task<Execution> CreateExecution(string functionId)
		{
			var response = await _appwrite.CallAsync("POST", $"{basePath}/{functionId}/executions");
			return JsonSerializer.Deserialize<Execution>(response);
		}
		public async Task<Execution> GetExecution(string functionId, string executionId)
		{
			var response = await _appwrite.CallAsync("POST", $"{basePath}/{functionId}/executions/{executionId}");
			return JsonSerializer.Deserialize<Execution>(response);
		}

		public async Task<Tag> UpdateTag(string functionId, string tag) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "tag", tag }
			};

			var response = await _appwrite.CallAsync("PUT", $"{basePath}/{functionId}/tag", parameters);
			return JsonSerializer.Deserialize<Tag>(response);
		}
		public async Task<TagsList> ListTags(string functionId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "search", search },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderType", orderType.ToString() }
			};

			var response = await _appwrite.CallAsync("GET", $"{basePath}/{functionId}/tags");
			return JsonSerializer.Deserialize<TagsList>(response);
		}

		public async Task<Tag> CreateTag(string functionId, string command, FileInfo code) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "command", command },
				{ "code", code }
			};

			Dictionary<string, string> headers = new Dictionary<string, string>()
			{
				{ "content-type", "multipart/form-data" }
			};
			// TODO: Figure out how to override content tipe to form-data multipart
			var response = await _appwrite.CallAsync("POST", $"{basePath}/{functionId}/tags");
			return JsonSerializer.Deserialize<Tag>(response);
		}
		public async Task<Tag> GetTag(string functionId, string tagId) {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/{functionId}/tags/{tagId}");
			return JsonSerializer.Deserialize<Tag>(response);
		}
		public async Task DeleteTag(string functionId, string tagId) {
			await _appwrite.CallAsync("DELETE", $"{basePath}/{functionId}/tags/{tagId}");
		}
	}
}
