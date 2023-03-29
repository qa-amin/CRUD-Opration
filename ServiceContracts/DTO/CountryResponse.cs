using System;
using Entities;

namespace ServiceContracts.DTO
{
	/// <summary>
	/// DTO class is used return type for CountryService
	/// </summary>
	public class CountryResponse
	{
		public Guid CountryId { get; set; }
		public string? CountyrName { get; set; }

		//It compares the current object to another object of CountryResponse type and returns true, if both values are same; otherwise returns false
		public override bool Equals(object? obj)
		{
			if (obj == null)
			{
				return false;
			}

			if (obj.GetType() != typeof(CountryResponse))
			{
				return false;
			}
			CountryResponse country_to_compare = (CountryResponse)obj;

			return CountryId == country_to_compare.CountryId && CountyrName == country_to_compare.CountyrName;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

	}

	public static class CountryExtensions
	{
		public static CountryResponse ToCountryResponse(this Country country)
		{
			return new CountryResponse
			{
				CountryId = country.CountryId,
				CountyrName = country.CountryName
			};
		}
	}
}
