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
