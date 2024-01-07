using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.People;

namespace ServiceContracts.People
{
    public interface IPersonApplication
    {
        void Create(CreatePerson person);
        void Edit(EditPerson person);
        List<PersonViewModel> GetPeople();
        Person GetById(string id);
    }
}
