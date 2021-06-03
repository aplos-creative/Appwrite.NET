using Appwrite.NET.Models;
using Appwrite.NET.Services;
using Appwrite.NET.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Appwrite.NET
{
	public static class ServicesExtensions
	{
		public static IServiceCollection AddAppwrite(this IServiceCollection services, AppwriteConfig config)
		{

			//services.AddHttpClient("appwrite", x =>
			//{
			//	x.BaseAddress = config.EndpointUri();
			//	x.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			//	x.DefaultRequestHeaders.Add("x-sdk-version", "appwrite:dotnet:0.2.0");
			//	x.DefaultRequestHeaders.Add("X-Appwrite-Project", config.ProjectId.ToString());
			//	if (config.Key != null)
			//		x.DefaultRequestHeaders.Add("X-Appwrite-Key", config.Key.ToString());
			//});

			services.AddSingleton<AppwriteConfig>(new AppwriteConfig { 
				Endpoint = config.Endpoint,
				ProjectId = config.ProjectId,
				SelfSigned = config.SelfSigned
			});

			services.AddHttpClient<AppwriteClient>();

			services.AddSingleton<IUsersService, UsersService>();

			return services;
		}

	}
}
