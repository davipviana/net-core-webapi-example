using System.Collections.Generic;
using WebApi.Example.Domain.Entity;

namespace WebApi.Example.Repository.Interface
{
    public interface IPersonRepository
    {
        Person GetById(long id);
        IEnumerable<Person> ListAll();
        Person Create(Person person);
        Person Update(long id, Person person);
        void Delete(long id);
    }
}