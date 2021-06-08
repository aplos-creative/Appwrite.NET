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
		Task<FunctionsList> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<Function> Create(string name, List<object> execute, string env, object vars = null, List<object> events = null, string schedule = "", int? timeout = 15);
		Task<Function> Get(string functionId);
		Task<Function> Update(string functionId, string name, List<object> execute, object vars = null, List<object> events = null, string schedule = "", int? timeout = 15);
		Task Delete(string functionId);
		Task<ExecutionsList> ListExecutions(string functionId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<Execution> CreateExecution(string functionId);
		Task<Execution> GetExecution(string functionId, string executionId);
		Task<Tag> UpdateTag(string functionId, string tag);
		Task<TagsList> ListTags(string functionId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC);
		Task<Tag> CreateTag(string functionId, string command, FileInfo code);
		Task<Tag> GetTag(string functionId, string tagId);
		Task DeleteTag(string functionId, string tagId);
	}
}
