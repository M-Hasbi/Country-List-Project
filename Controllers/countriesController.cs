using Country_List_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Country_List_Project.Controllers
{
    public class CountriesController : ApiController
    {
        List<Country> countries = new List<Country>();
        public CountriesController()
        {
            countries.Add(new Country { countryCodes = { "CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN" } });
        }

        // GET: api/Countries
        public List<Country> Get()
        {
            return countries;
        }

        // GET: api/Countries/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Countries
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Countries/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Countries/5
        public void Delete(int id)
        {
        }
    }
}
