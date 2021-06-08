using Appwrite.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite.NET.Interfaces
{
	public interface ILocaleService
	{
		Task<Locale> Get();
		Task<ContinentsList> GetContinents();
		Task<CountriesList> GetCountries();
		Task<CountriesList> GetCountriesEU();
		Task<PhoneCodesList> GetPhoneCodes();
		Task<CurrenciesList> GetCurrencies();
		Task<LanguagesList> GetLanguages();
	}
}
