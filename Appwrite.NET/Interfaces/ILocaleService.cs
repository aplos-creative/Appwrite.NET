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
		Task<List<Continent>> GetContinents();
		Task<List<Country>> GetCountries();
		Task<List<Country>> GetCountriesEU();
		Task<List<PhoneCode>> GetPhoneCodes();
		Task<List<Currency>> GetCurrencies();
		Task<List<Language>> GetLanguages();
	}
}
