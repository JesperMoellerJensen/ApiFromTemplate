using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFromTemplate.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiFromTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        CityRepository repo = new CityRepository();


        // GET: api/<controller>
        [HttpGet]
        public List<City> Get()
        {
            return repo.Cities;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public City Get(int id)
        {
            return repo.Cities[id];
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
            var test = value;
            var test2 = test;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
