using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface IHealthService
	{
		Task Get();
		Task GetAntiVirus();
		Task GetCache();
		Task GetDB();
		Task GetQueueCertificates();
		Task GetQueueFunctions();
		Task GetQueueLogs();
		Task GetQueueTasks();
		Task GetQueueUsage();
		Task GetQueueWebhooks();
		Task GetStorageLocal();
		Task GetTime();
	}
}
