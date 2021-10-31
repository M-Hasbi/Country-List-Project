using Country_List_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Country_List_Project.Controllers
{/// <summary>
/// This is where you can find all the travel path information which our trucks are able to travelthrough. 
/// </summary>
    public class CountriesController : ApiController
    {
        List<Country> countries = new List<Country>();
        List<DestinationCountry> destinationCountries = new List<DestinationCountry>();
        /// <summary>
        /// This is the database which created in the ctor(construction) of the CountriesController  
        /// </summary>
        public CountriesController() 
        {
            countries.Add(new Country { countryCodes = { "CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN" } });
            destinationCountries.Add(new DestinationCountry {destination = "CAN", list = {"USA", "CAN"} });
            destinationCountries.Add(new DestinationCountry { destination = "MEX", list = { "USA", "MEX" } });
            destinationCountries.Add(new DestinationCountry { destination = "BLZ", list = { "USA", "MEX", "BLZ" } });
            destinationCountries.Add(new DestinationCountry { destination = "GTM", list = { "USA", "MEX", "GTM" } });
            destinationCountries.Add(new DestinationCountry { destination = "SLV", list = { "USA", "MEX", "GTM", "SLV" } });
            destinationCountries.Add(new DestinationCountry { destination = "HND", list = { "USA", "MEX", "GTM", "HND" } });
            destinationCountries.Add(new DestinationCountry { destination = "NIC", list = { "USA", "MEX", "GTM", "HND", "NIC"} });
            destinationCountries.Add(new DestinationCountry { destination = "CRI", list = { "USA", "MEX", "GTM", "HND", "NIC", "CRI" } });
            destinationCountries.Add(new DestinationCountry { destination = "PAN", list = { "USA", "MEX", "GTM", "HND", "NIC", "CRI", "PAN"  } });
            
        }

        // GET: countries
        /// <summary>
        /// Gets a list of the countries which our trucks are able to travel through 
        /// </summary>
        /// <returns>A list of countries</returns>
        [Route("countries")]
        [HttpGet]
        public List<Country> Get()
        {
            return countries;
        }

        /// <summary>
        /// Gets name of the destanation country and its border countries that our trucks are going to be passed through
        /// </summary>
        /// <param name="code">3 letters of the country code </param>
        /// <returns> name of the destanation country and its border countries that our trucks are going to be passed through</returns>
        // GET: code
        [Route("{code}")]
        [HttpGet]
        public DestinationCountry Get(string code)
        {
            return destinationCountries.Where(x => x.destination==code.ToUpper()).FirstOrDefault();
            
        }

    }
}
