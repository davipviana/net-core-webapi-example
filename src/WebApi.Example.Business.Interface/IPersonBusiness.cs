using System.Collections.Generic;
using WebApi.Example.Domain.Entity;

namespace WebApi.Example.Business.Interface
{
    public interface IPersonBusiness
    {
        Person GetById(long id);
        IEnumerable<Person> ListAll();
        Person Create(Person person);
        Person Update(long id, Person person);
        void Delete(long id);
    }
}