using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using WebApi.Example.Domain.Entity;
using WebApi.Example.Interface.Repository;
using WebApi.Example.Util;

namespace WebApi.Example.Repository
{
    public class PersonRepository : BaseRepository, IPersonRepository
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }
        
        public Person GetById(long id)
        {
            return new Person
            {
                Id = id
            };
        }
        
        [CacheMethod]
        public IEnumerable<Person> ListAll()
        {
            return new List<Person>();
        }

        public Person Update(long id, Person person)
        {
            return person;
        }
    }
}
