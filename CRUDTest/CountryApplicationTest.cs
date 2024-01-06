using ServiceContracts.Countries;
using Services;
using Xunit;

namespace CRUDTest
{
    public class CountryApplicationTest
    {
        private readonly ICountryApplication _countryApplication;

        public CountryApplicationTest()
        {
            _countryApplication = new CountryApplication();
        }

        #region CreateCountry
        //When CountryAddRequest is null, it should throw ArgumentNullException
        [Fact]
        public void CreateCountry_NullCountry()
        {
            //Arrange
            CreateCountry? request = null;

            //Assert
            Assert.Throws<ArgumentNullException>(() =>
           {
               //Act
               _countryApplication.Create(request);
           });

        }
        [Fact]
        public void CreateCountry_NullCountryName()
        {
            //Arrange
            CreateCountry? request = new CreateCountry() { Name = null };


            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                _countryApplication.Create(request);

            });

        }
        [Fact]
        public void CreateCountry_DuplicateCountryName()
        {
            //Arrange
            CreateCountry? request1 = new CreateCountry() { Name = "IRAN" };
            CreateCountry? request2 = new CreateCountry() { Name = "IRAN" };

            //Assert
            Assert.Throws<ArgumentException>(() =>
           {
               _countryApplication.Create(request1);
               _countryApplication.Create(request2);
           });

        }

        #endregion

      

    }
}
