using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface IFunctionsService
	{
		Task List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task Create(string name, List<object> execute, string env, object vars = null, List<object> events = null, string schedule = "", int? timeout = 15);
		Task Get(string functionId);
		Task Update(string functionId, string name, List<object> execute, object vars = null, List<object> events = null, string schedule = "", int? timeout = 15);
		Task Delete(string functionId);
		Task ListExecutions(string functionId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task CreateExecution(string functionId);
		Task GetExecution(string functionId, string executionId);
		Task UpdateTag(string functionId, string tag);
		Task ListTags(string functionId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task CreateTag(string functionId, string command, FileInfo code);
		Task GetTag(string functionId, string tagId);
		Task DeleteTag(string functionId, string tagId);
	}
}
