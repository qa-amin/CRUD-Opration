namespace Entities.Countries
{
    /// <summary>
    /// Domin Model for Country
    /// </summary>
    public class Country
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public Country(Guid id, string? name)
        {
            Id = id;
            Name = name;
        }

        public void Edit(string name)
        {
            Name = name;
        }
    }
}