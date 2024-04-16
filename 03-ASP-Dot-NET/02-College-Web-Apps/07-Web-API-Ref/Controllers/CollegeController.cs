using _07_Web_API.Models;
using _07_Web_API.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _07_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        // ****** Dependency Injection of ProductRepo using Interface(IRepository) ******
        private readonly IRepository<College> _collegerepo = null;
        public CollegeController(IRepository<College> collegerepo)
        {
            _collegerepo = collegerepo;
        }
        // GET: api/<CollegeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CollegeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CollegeController>
        [HttpPost]
        // ************ Modify the pre-built method name ***********
        // public void Post([FromBody] string value)
        public void InsertRecord(College clz)
        {

        }

        // PUT api/<CollegeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CollegeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
