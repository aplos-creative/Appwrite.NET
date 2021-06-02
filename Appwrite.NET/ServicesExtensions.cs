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

			services.AddHttpClient("appwrite", x =>
			{
				x.BaseAddress = config.EndpointUri();
				x.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				x.DefaultRequestHeaders.Add("x-sdk-version", "appwrite:dotnet:0.2.0");
				x.DefaultRequestHeaders.Add("X-Appwrite-Project", config.ProjectId.ToString());
				if (config.Key != null)
					x.DefaultRequestHeaders.Add("X-Appwrite-Key", config.Key.ToString());
			});

			services.AddSingleton<IUsersService, UsersService>();

			return services;
		}

	}

	public static class ConfigurationExtensions
	{
		public const string DEFAULT_CONFIG_SECTION = "Appwrite";

		public static AppwriteConfig GetAppwriteConfig(this IConfiguration config)
		{
			return GetAppwriteConfig(config, DEFAULT_CONFIG_SECTION);
		}

		public static AppwriteConfig GetAppwriteConfig(this IConfiguration config, string configSection)
		{
			var options = new AppwriteConfig();

			IConfiguration section;

			if (string.IsNullOrEmpty(configSection))
				section = config;
			else
				section = config.GetSection(configSection);

			if (section == null)
				return options;

			var awConfigTypeInfo = typeof(AppwriteConfig).GetTypeInfo();

			// TODO: Check primitives and throw exception for issues

			if (!string.IsNullOrEmpty(section["ProjectId"]))
			{
				options.ProjectId = section["ProjectId"];
			}

			if (!string.IsNullOrEmpty(section["Endpoint"]))
			{
				options.Endpoint = section["Endpoint"];
			}

			if (!string.IsNullOrEmpty(section["Key"]))
			{
				options.Key = section["Key"];
			}

			if (!string.IsNullOrEmpty(section[""]))
			{
				options.SelfSigned = bool.Parse(section["SelfSigned"]);
			}

			return options;
		}
	}
}
