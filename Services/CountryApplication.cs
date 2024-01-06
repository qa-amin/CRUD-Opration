using Entities.Countries;
using ServiceContracts.Countries;

namespace Services
{
    public class CountryApplication : ICountryApplication
	{
		private readonly List<Country> _contries;

		public CountryApplication()
		{
			_contries = new List<Country> ();
		}
        

        public void Create(CreateCountry entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (entity.Name == null)
            {
                throw new ArgumentException(nameof(entity.Name));
            }

            if (_contries.Any(country => country.Name == entity.Name))
            {
                throw new ArgumentException("Given Country already Exists");
            }

            var country = new Country(Guid.NewGuid(), entity.Name);

			_contries.Add(country);


        }

        public void Edit(EditCountry entity)
        {
            var country = GetCountryById(entity.Id);

            if (country == null) { }

            country.Edit(entity.Name);

        }

        public List<CountryViewModel> GetCountries()
        {
            var countryList = _contries.Select(country => new CountryViewModel
            {
				Id = country.Id.ToString(),
				Name = country.Name,
            }).ToList();

            return countryList;
        }

        public Country GetCountryById(string id)
        {
            return _contries.FirstOrDefault(c => c.Id == Guid.Parse(id));
        }
    }
}