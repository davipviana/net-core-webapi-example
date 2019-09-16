using Microsoft.AspNetCore.Mvc;
using WebApi.Example.Business.Interface;
using WebApi.Example.Domain.Entity;

namespace WebApi.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        #region Properties
        private IPersonBusiness _personBusiness;
        #endregion

        #region Constructors
        public PersonsController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }
        #endregion

        // GET api/persons
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personBusiness.ListAll());
        }

        // GET api/persons/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_personBusiness.GetById(id));
        }

        // POST api/persons
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            _personBusiness.Create(person);

            return Ok(person);
        }

        // PUT api/persons/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person person)
        {
            _personBusiness.Update(id, person);

            return Ok(person);
        }

        // DELETE api/persons/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personBusiness.Delete(id);

            return NoContent();
        }
    }
}
