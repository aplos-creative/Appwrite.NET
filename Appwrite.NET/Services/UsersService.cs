using Appwrite.NET.Interfaces;
using Appwrite.NET.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
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

		public async Task List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) {

		}
		public async Task<User> Create(UserCreateDTO newUser) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "email", newUser.Email },
				{ "password", newUser.Password },
				{ "name", newUser.Name }
			};

			var response = await _appwrite.CallAsync("POST", basePath, parameters);



			var user = JsonConvert.DeserializeObject<User>(response.Replace("$id", "id"));

			return user;
		}
		public async Task Get(string userId) { throw new NotImplementedException(); }
		public async Task DeleteUser(string userId) { throw new NotImplementedException(); }
		public async Task GetLogs(string userId) { throw new NotImplementedException(); }
		public async Task GetPrefs(string UserId) { throw new NotImplementedException(); }
		public async Task UpdatePrefs(string UserId, object prefs) { throw new NotImplementedException(); }
		public async Task GetSessions(string userId) { throw new NotImplementedException(); }
		public async Task DeleteSessions(string userId) { throw new NotImplementedException(); }
		public async Task DeleteSession(string userId, string sessionId) { throw new NotImplementedException(); }
		public async Task UpdateStatus(string userId, string status) { throw new NotImplementedException(); }
	}
}
