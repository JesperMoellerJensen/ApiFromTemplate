using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


        // GET: api/<controller>
        [HttpGet]
        public List<City> Get()
        {
            return CityDatabase.Cities;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public City Get(int id)
        {
            return CityDatabase.Cities[id];
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]City value)
        {
            CityDatabase.Cities.Add(value);
        }

        // PUT api/<controller>/5
        /* [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            City removeCity = CityDatabase.Cities.First(x => x.Id == id);
            CityDatabase.Cities
        }
        */

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            City removeCity = CityDatabase.Cities.First(x => x.Id == id);
            CityDatabase.Cities.Remove(removeCity);
        }

        // PATCH api/<controller>/5
        [HttpPatch ("{id}")]
        public void Patch(int id, [FromBody] Models.City city)
        {
            City updateCity = CityDatabase.Cities.First(x => x.Id == id);

            
            
            

        }

    }
}
