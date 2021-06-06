using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface ITeamsService
	{
		Task<TeamsList> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<Team> Create(TeamCreateDTO team);
		Task<Team> Get(string teamId);
		Task<Team> Update(string teamId, string Name);
		Task Delete(string TeamId);
		Task<List<Membership>> GetMemberships(string TeamId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<Membership> CreateMembership(MembershipCreateDTO membership);
		Task DeleteMembership(string TeamId, string InviteId);
	}
}
