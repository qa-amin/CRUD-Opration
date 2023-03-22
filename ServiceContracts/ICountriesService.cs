using ServiceContracts;
using ServiceContracts.DTO;
namespace ServiceContracts
{
	/// <summary>
	/// Represents business logic for manipulating Counrty Entity
	/// </summary>
	public interface ICountriesService
	{
		/// <summary>
		/// add a country object to the list of countries
		/// </summary>
		/// <param name="countryAddRequest">Country object to add</param>
		/// <returns>Retruns the country object after adding it</returns>
		CountryResponse AddCountry(CountryAddRequest countryAddRequest);
	}
}