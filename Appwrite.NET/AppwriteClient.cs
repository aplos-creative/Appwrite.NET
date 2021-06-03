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
	public class AppwriteClient
	{
		private HttpClient _http;
		private AppwriteConfig _config;

		public AppwriteClient(HttpClient httpClient, AppwriteConfig config)
		{
			_http = httpClient;
			_config = config;

			InitializeHttpClient();
		}

		private void InitializeHttpClient()
		{
			_http.BaseAddress = _config.EndpointUri();
			_http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			_http.DefaultRequestHeaders.Add("x-sdk-version", "appwrite:dotnet:0.2.0");
			_http.DefaultRequestHeaders.Add("X-Appwrite-Project", _config.ProjectId.ToString());
			if (_config.Key != null)
				_http.DefaultRequestHeaders.Add("X-Appwrite-Key", _config.Key.ToString());
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

		public async Task<string> GetAsync(string path, Dictionary<string, object> parameters) {
			var response = await _http.GetAsync(_http.BaseAddress.AbsoluteUri + path + ToParametersString(parameters));
			var content = await response.Content.ReadAsStringAsync();

			if ((int)response.StatusCode >= 400)
				HandleException(content, (int)response.StatusCode);

			return content;
		}

		public async Task<string> PostAsync(string path, Dictionary<string, object> parameters) {
			var response = await _http.PostAsJsonAsync(_http.BaseAddress.AbsoluteUri + path, parameters);
			var content = await response.Content.ReadAsStringAsync();

			if ((int)response.StatusCode >= 400)
				HandleException(content, (int)response.StatusCode);

			return content;
		}

		public async Task<string> PutAsync(string path, Dictionary<string, object> parameters) {
			var response = await _http.PutAsJsonAsync(_http.BaseAddress.AbsoluteUri + path, parameters);
			var content = await response.Content.ReadAsStringAsync();

			if ((int)response.StatusCode >= 400)
				HandleException(content, (int)response.StatusCode);

			return content;
		}

		public async Task<string> DeleteAsync(string path) {
			var response = await _http.DeleteAsync(_http.BaseAddress.AbsoluteUri + path);
			var content = await response.Content.ReadAsStringAsync();

			if ((int)response.StatusCode >= 400)
				HandleException(content, (int)response.StatusCode);

			return content;
		}

		private void HandleException(string response, int statusCode) {
			string message = (JObject.Parse(response))["message"].ToString();
			throw new AppwriteException(message, statusCode, response.ToString());
		}

		private string ToParametersString(Dictionary<string, object> parameters)
		{
			return string.Join("&", parameters.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value)));
		}
	}
}
