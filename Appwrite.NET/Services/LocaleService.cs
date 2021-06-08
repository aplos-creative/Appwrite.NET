using Appwrite.NET.Interfaces;
using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Appwrite.NET.Services
{
	public class LocaleService: ILocaleService
	{
		private AppwriteClient _appwrite;
		private const string basePath = "/locale";
		public LocaleService(AppwriteClient appwrite)
		{
			_appwrite = appwrite;
		}

		public async Task<Locale> Get() {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/locale");

			return JsonSerializer.Deserialize<Locale>(response);
		}
		public async Task<ContinentsList> GetContinents() {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/continents");

			return JsonSerializer.Deserialize<ContinentsList>(response);
		}
		public async Task<CountriesList> GetCountries() {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/countries");

			return JsonSerializer.Deserialize<CountriesList>(response);
		}
		public async Task<CountriesList> GetCountriesEU() {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/countries/eu");

			return JsonSerializer.Deserialize<CountriesList>(response);
		}
		public async Task<PhoneCodesList> GetPhoneCodes() {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/phones");

			return JsonSerializer.Deserialize<PhoneCodesList>(response);
		}
		public async Task<CurrenciesList> GetCurrencies() {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/currencies");

			return JsonSerializer.Deserialize<CurrenciesList>(response);
		}
		public async Task<LanguagesList> GetLanguages() {
			var response = await _appwrite.CallAsync("GET", $"{basePath}/languages");

			return JsonSerializer.Deserialize<LanguagesList>(response);
		}
	}
}
