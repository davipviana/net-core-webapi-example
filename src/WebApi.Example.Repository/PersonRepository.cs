using System;
using System.Collections.Generic;
using WebApi.Example.Domain.Entity;
using WebApi.Example.Interface.Repository;

namespace WebApi.Example.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Person GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> ListAll()
        {
            throw new NotImplementedException();
        }

        public Person Update(long id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
