using Appwrite.NET.Interfaces;
using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Appwrite.NET.Services
{
	public class UsersService : IUsersService
	{
		private AppwriteClient _appwrite;
		private const string basePath = "/users";

		public UsersService(AppwriteClient appwrite) {
			_appwrite = appwrite;
		}

		public async Task<UsersList> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "search", search },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderType", orderType.ToString() }
			};

			var response = await _appwrite.CallAsync("GET", basePath, parameters);

			return JsonSerializer.Deserialize<UsersList>(response);
		}
		public async Task<User> Create(string Email, string Password, string Name) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "email", Email },
				{ "password", Password },
				{ "name", Name }
			};

			var response = await _appwrite.CallAsync("POST", basePath, parameters);

			return JsonSerializer.Deserialize<User>(response);
		}
		public async Task<User> Get(string userId) {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/{userId}");

			return JsonSerializer.Deserialize<User>(response);
		}
		public async Task DeleteUser(string userId) {
			await _appwrite.CallAsync("DELETE", $"{basePath}/{userId}");
		}
		public async Task<LogsList> GetLogs(string userId) {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/{userId}/logs");
			return JsonSerializer.Deserialize<LogsList>(response);
		}
		public async Task<object> GetPrefs(string userId) {
			var response = await _appwrite.CallAsync("PUT", $"{basePath}/{userId}/prefs");
			return JsonSerializer.Deserialize<object>(response);
		}

		public async Task<object> UpdatePrefs(string userId, object prefs) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "prefs", prefs }
			};

			var response = await _appwrite.CallAsync("PUT", $"{basePath}/{userId}/prefs", parameters);
			return JsonSerializer.Deserialize<object>(response);
		}
		public async Task<SessionsList> GetSessions(string userId) {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/{userId}/sessions");
			return JsonSerializer.Deserialize<SessionsList>(response);
		}
		public async Task DeleteSessions(string userId) {
			await _appwrite.CallAsync("DELETE", $"{basePath}/{userId}/sessions");
		}
		public async Task DeleteSession(string userId, string sessionId) {
			 await _appwrite.CallAsync("GET", $"{basePath}/{userId}/sessions/{sessionId}");
		}
		public async Task<User> UpdateStatus(string userId, string status) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "status", status }
			};

			var response = await _appwrite.CallAsync("PUT", $"{basePath}/{userId}/prefs", parameters);
			return JsonSerializer.Deserialize<User>(response);
		}
	}
}
