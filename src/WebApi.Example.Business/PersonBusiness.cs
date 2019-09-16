using System.Collections.Generic;
using WebApi.Example.Business.Interface;
using WebApi.Example.Domain.Entity;
using WebApi.Example.Repository.Interface;

namespace WebApi.Example.Business
{
    public class PersonBusiness : IPersonBusiness
    {
        #region Properties
        private IPersonRepository _personRepository;
        #endregion

        #region Constructors
        public PersonBusiness(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        #endregion

        #region IPersonBusiness methods
        public Person Create(Person person)
        {
            return _personRepository.Create(person);
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
        }

        public Person GetById(long id)
        {
            return _personRepository.GetById(id);
        }

        public IEnumerable<Person> ListAll()
        {
            return _personRepository.ListAll();
        }

        public Person Update(long id, Person person)
        {
            return _personRepository.Update(id, person);
        }
        #endregion
    }
}
