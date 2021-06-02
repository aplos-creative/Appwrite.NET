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
		Task List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<User> Create(UserCreateDTO newUser);
		Task Get(string userId);
		Task DeleteUser(string userId);
		Task GetLogs(string userId);
		Task GetPrefs(string UserId);
		Task UpdatePrefs(string UserId, object prefs);
		Task GetSessions(string userId);
		Task DeleteSessions(string userId);
		Task DeleteSession(string userId, string sessionId);
		Task UpdateStatus(string userId, string status);
	}
}
