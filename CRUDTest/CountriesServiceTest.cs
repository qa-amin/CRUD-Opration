﻿using ServiceContracts;
using Entities;
using System;
using Services;
using ServiceContracts.DTO;

namespace CRUDTest
{
	public class CountriesServiceTest
	{
		private readonly ICountriesService _countriesService;

		public CountriesServiceTest()
		{
			_countriesService = new CountriesService();
		}

		//When CountryAddRequest is null, it should throw ArgumentNullException
		[Fact]
		public void AddCountry_NullCountry()
		{
			//Arrange
			CountryAddRequest? request = null;

			//Assert
			Assert.Throws<ArgumentNullException>(() =>
			{
				//Act
				_countriesService.AddCountry(request);
			});
		}

		//When the CountryName is null, it should throw ArgumentException
		[Fact]
		public void AddCountry_CountryNameIsNull()
		{
			//Arrange
			CountryAddRequest? request = new CountryAddRequest() { CountryName = null };

			//Assert
			Assert.Throws<ArgumentException>(() =>
			{
				//Act
				_countriesService.AddCountry(request);
			});
		}

	}
}
