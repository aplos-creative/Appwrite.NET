using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface IUsersService
	{
		Task<UsersList> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<User> Create(string Email, string Password, string Name);
		Task<User> Get(string userId);
		Task DeleteUser(string userId);
		Task<List<Log>> GetLogs(string userId);
		Task<object> GetPrefs(string userId);
		Task<object> UpdatePrefs(string userId, object prefs);
		Task<List<Session>> GetSessions(string userId);
		Task DeleteSessions(string userId);
		Task DeleteSession(string userId, string sessionId);
		Task<User> UpdateStatus(string userId, string status);
	}
}
