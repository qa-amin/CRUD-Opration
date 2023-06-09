﻿using Entities;
using ServiceContracts;
using ServiceContracts.DTO;
using System.Collections.Generic;

namespace Services
{
	public class CountriesService : ICountriesService
	{
		private readonly List<Country> _contries;

		public CountriesService()
		{
			_contries = new List<Country> ();
		}
		#region AddCountry
		public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
		{
			// validation CountryAddRequest  ArgumentNullException when it is null
			if (countryAddRequest == null)
			{
				throw new ArgumentNullException(nameof(CountryAddRequest));
			}

			// validation CountryAddRequest.CountryName  ArgumentException when it is null
			if (countryAddRequest.CountryName == null)
			{
				throw new ArgumentException(nameof(countryAddRequest.CountryName));
			}

			// validation CountryAddRequest.CountryName Duplication  ArgumentException when it is Duplicate
			if (_contries.Where(c => c.CountryName == countryAddRequest.CountryName).Count() > 0)
			{
				throw new ArgumentException("Country name alredy exists!!!");
			}
			// convert object from CountryAddRequest to Country type
			Country country = countryAddRequest.ToCountry();

			// genarate CountryId
			country.CountryId = Guid.NewGuid();

			// add country object to _contries
			_contries.Add(country);

			CountryResponse countryResponse = country.ToCountryResponse();

			return countryResponse;
		}


		#endregion

		#region GetAllCounries
		public List<CountryResponse> GetAllCountries()
		{
			return _contries.Select(country => country.ToCountryResponse()).ToList();
		}

		#endregion

		#region GetCountryByCountryId

		public CountryResponse? GetCountryByCountryId(Guid? countryId)
		{
			if(countryId == null)
			{
				return null;
			}
			Country? country = _contries.FirstOrDefault(country => country.CountryId == countryId);
			if(country == null)
			{
				return null;
			}

			return country.ToCountryResponse(); 
		}
		#endregion
	}
}