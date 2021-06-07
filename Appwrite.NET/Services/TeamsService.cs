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
	public class TeamsService: ITeamsService
	{
		private AppwriteClient _appwrite;
		private const string basePath = "/teams";
		public TeamsService(AppwriteClient appwrite) {
			_appwrite = appwrite;
		}

		public async Task<TeamsList> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "search", search },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderType", orderType.ToString() }
			};

			var response = await _appwrite.CallAsync("GET", basePath, parameters);

			return JsonSerializer.Deserialize<TeamsList>(response);
		}
		public async Task<Team> Create(string Name, List<string> Roles) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "name", Name },
				{ "roles", Roles }
			};

			var response = await _appwrite.CallAsync("POST", basePath, parameters);

			return JsonSerializer.Deserialize<Team>(response);
		}
		public async Task<Team> Get(string teamId) {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/{teamId}");

			return JsonSerializer.Deserialize<Team>(response);
		}
		public async Task<Team> Update(string teamId, string Name) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "name", Name }
			};

			var response = await _appwrite.CallAsync("PUT", $"{basePath}/{teamId}", parameters);
			return JsonSerializer.Deserialize<Team>(response);
		}
		public async Task Delete(string TeamId) {
			await _appwrite.CallAsync("DELETE", $"{basePath}/{TeamId}");
		} 
		public async Task<List<Membership>> GetMemberships(string TeamId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "search", search },
				{ "limit", limit },
				{ "offset", offset },
				{ "orderType", orderType.ToString() }
			};

			var response = await _appwrite.CallAsync("GET", $"{basePath}/{TeamId}/memberships");
			return JsonSerializer.Deserialize<MembershipsList>(response).Memberships;
		} 
		public async Task<Membership> CreateMembership(string TeamId, string Email, List<string> Roles, string Url, string Name) {
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "email", Email },
				{ "name", Name },
				{ "roles", Roles },
				{ "url", Url }
			};

			var response = await _appwrite.CallAsync("POST", $"{basePath}/{TeamId}/memberships", parameters);
			return JsonSerializer.Deserialize<Membership>(response);
		} 
		public async Task DeleteMembership(string TeamId, string InviteId) {
			await _appwrite.CallAsync("DELETE", $"{basePath}/{TeamId}/memberships/{InviteId}");
		} 
	}
}
