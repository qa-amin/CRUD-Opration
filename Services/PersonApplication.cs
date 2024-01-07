using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.People;
using ServiceContracts.People;

namespace Services
{
    public class PersonApplication : IPersonApplication
    {
        private readonly List<Person> _people;

        public PersonApplication(List<Person> people)
        {
            _people = people;
        }

        public void Create(CreatePerson person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));
            if (person.Name == null) throw new ArgumentException();

            var createPerson = new Person(Guid.NewGuid(), person.Name,
                person.Email, person.DateOfBirth, person.Gender,person.CountryId,person.Address,person.ReceiveNewsLetters);
        }

        public void Edit(EditPerson person)
        {
            var editPerson = GetById(person.Id);
            if(editPerson == null) throw new ArgumentException();
            editPerson.Edit(person.Name,person.Email, person.DateOfBirth,person.Gender, person.CountryId,
                person.Address, person.ReceiveNewsLetters);
        }

        public List<PersonViewModel> GetPeople()
        {
            return _people.Select(p => new PersonViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Address = p.Address,
                CountryId = p.CountryId,
                Age = Math.Round(((DateTime.Now.Subtract(p.DateOfBirth)).TotalDays) / 365.25),
                Email = p.Email,
                Gender = p.Gender.ToString(),
                ReceiveNewsLetters = p.ReceiveNewsLetters,

            }).ToList();
        }

        public Person GetById(string id)
        {
            return _people.FirstOrDefault(p => p.Id == Guid.Parse(id));
        }
    }
}
