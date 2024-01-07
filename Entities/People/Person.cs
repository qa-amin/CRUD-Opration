namespace Entities.People
{
    /// <summary>
    /// Person domain model class
    /// </summary>
    public class Person
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderOperation Gender { get; set; }
        public Guid? CountryId { get; set; }
        public string? Address { get; set; }
        public bool ReceiveNewsLetters { get; set; }

        public Person(Guid id, string? name, string? email, DateTime dateOfBirth, int gender, Guid? countryId, string? address, bool receiveNewsLetters)
        {
            Id = id;
            Name = name;
            Email = email;
            DateOfBirth = dateOfBirth;
            Gender = gender == 1 ? GenderOperation.Male : GenderOperation.Female;
            CountryId = countryId;
            Address = address;
            ReceiveNewsLetters = receiveNewsLetters;
        }


        public void Edit( string? name, string? email, DateTime dateOfBirth, int gender, Guid? countryId, string? address, bool receiveNewsLetters)
        {
            Name = name;
            Email = email;
            DateOfBirth = dateOfBirth;
            Gender = gender == 1 ? GenderOperation.Male : GenderOperation.Female;
            CountryId = countryId;
            Address = address;
            ReceiveNewsLetters = receiveNewsLetters;
        }
    }
}
