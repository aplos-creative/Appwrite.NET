using Appwrite.NET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Services
{
	public class HealthService: IHealthService
	{
		private AppwriteClient _appwrite;
		private const string basePath = "/locale";
		public HealthService(AppwriteClient appwrite)
		{
			_appwrite = appwrite;
		}

		public async Task Get() => new NotImplementedException();
		public async Task GetAntiVirus() => new NotImplementedException();
		public async Task GetCache() => new NotImplementedException();
		public async Task GetDB() => new NotImplementedException();
		public async Task GetQueueCertificates() => new NotImplementedException();
		public async Task GetQueueFunctions() => new NotImplementedException();
		public async Task GetQueueLogs() => new NotImplementedException();
		public async Task GetQueueTasks() => new NotImplementedException();
		public async Task GetQueueUsage() => new NotImplementedException();
		public async Task GetQueueWebhooks() => new NotImplementedException();
		public async Task GetStorageLocal() => new NotImplementedException();
		public async Task GetTime() => new NotImplementedException();
	}
}
