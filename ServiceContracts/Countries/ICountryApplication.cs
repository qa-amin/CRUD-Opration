using Entities.Countries;

namespace ServiceContracts.Countries
{
    public interface ICountryApplication
    {
        void Create(CreateCountry entity);
        void Edit(EditCountry  entity);
        List<CountryViewModel> GetCountries();
        Country GetCountryById(string id);

    }
}
