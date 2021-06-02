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
		private IHttpClientFactory _httpClientFactory;

		public UsersService(IHttpClientFactory httpClientFactory) {
			_httpClientFactory = httpClientFactory;
		}

		public async Task List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) { throw new NotImplementedException(); }
		public async Task<User> Create(UserCreateDTO newUser) {
			string path = "/users";

			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "email", newUser.Email },
				{ "password", newUser.Password },
				{ "name", newUser.Name }
			};

			var client = _httpClientFactory.CreateClient("appwrite");


			var result = await client.PostAsJsonAsync(client.BaseAddress.AbsolutePath + path, parameters);
			var response = await result.Content.ReadAsStringAsync();

			// Should respond with a 201 status code
			if ((int)result.StatusCode >= 400)
			{

				string message = (JObject.Parse(response))["message"].ToString();
				throw new AppwriteException(message, (int)result.StatusCode, response.ToString());
			}

			var user = JsonConvert.DeserializeObject<User>(response);

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
