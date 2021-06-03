using Appwrite.NET.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET
{
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
