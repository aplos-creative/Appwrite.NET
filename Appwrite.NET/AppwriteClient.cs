using Appwrite.NET.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET
{
	public interface IAppwriteClient {
		Task<string> CallAsync(string method, string path, Dictionary<string, object> parameters = null);
		string GetEndpoint();
	}

	public class AppwriteClient
	{
		private IHttpClientFactory _httpFactory;
		private AppwriteConfig _config;

		public AppwriteClient(IHttpClientFactory factory, AppwriteConfig config)
		{
			_httpFactory = factory;
			_config = config;
		}


		public async Task<string> CallAsync(string method, string path, Dictionary<string, object> parameters = null)
		{
			return method.ToUpper() switch
			{
				"GET" => await GetAsync(path, parameters),
				"POST" => await PostAsync(path, parameters),
				"PUT" => await PutAsync(path, parameters),
				"DELETE" => await DeleteAsync(path),
				_ => throw new AppwriteException($"The HTTP Method your provided 'method' is invalid!")
			};
		}

		public string GetEndpoint()
		{
			return _config.Endpoint;
		}
		public async Task<string> GetAsync(string path, Dictionary<string, object> parameters) {
			var client = _httpFactory.CreateClient();

			if (_config.Key != null)
				client.DefaultRequestHeaders.Add("X-Appwrite-Key", _config.Key.ToString());

			var response = await client.GetAsync(client.BaseAddress.AbsoluteUri + path + ToParametersString(parameters));
			var content = await response.Content.ReadAsStringAsync();

			if ((int)response.StatusCode >= 400)
				HandleException(content, (int)response.StatusCode);

			client.Dispose();

			return content;
		}

		public async Task<string> PostAsync(string path, Dictionary<string, object> parameters) {
			var client = _httpFactory.CreateClient();

			if (_config.Key != null)
				client.DefaultRequestHeaders.Add("X-Appwrite-Key", _config.Key.ToString());

			var response = await client.PostAsJsonAsync(client.BaseAddress.AbsoluteUri + path, parameters);
			var content = await response.Content.ReadAsStringAsync();

			if ((int)response.StatusCode >= 400)
				HandleException(content, (int)response.StatusCode);

			client.Dispose();

			return content;
		}

		public async Task<string> PutAsync(string path, Dictionary<string, object> parameters) {
			var client = _httpFactory.CreateClient();

			if (_config.Key != null)
				client.DefaultRequestHeaders.Add("X-Appwrite-Key", _config.Key.ToString());

			var response = await client.PutAsJsonAsync(client.BaseAddress.AbsoluteUri + path, parameters);
			var content = await response.Content.ReadAsStringAsync();

			if ((int)response.StatusCode >= 400)
				HandleException(content, (int)response.StatusCode);

			client.Dispose();

			return content;
		}

		public async Task<string> DeleteAsync(string path) {
			var client = _httpFactory.CreateClient();

			if (_config.Key != null)
				client.DefaultRequestHeaders.Add("X-Appwrite-Key", _config.Key.ToString());

			var response = await client.DeleteAsync(client.BaseAddress.AbsoluteUri + path);
			var content = await response.Content.ReadAsStringAsync();

			if ((int)response.StatusCode >= 400)
				HandleException(content, (int)response.StatusCode);

			client.Dispose();

			return content;
		}

		private void HandleException(string response, int statusCode) {
			string message = (JObject.Parse(response))["message"].ToString();
			throw new AppwriteException(message, statusCode, response.ToString());
		}

		private string ToParametersString(Dictionary<string, object> parameters)
		{
			if (parameters == null) return "";

			return string.Join("&", parameters.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value)));
		}
	}
}
