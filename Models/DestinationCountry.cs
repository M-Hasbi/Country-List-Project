using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Country_List_Project.Models
{/// <summary>
/// Represents destination country and its borders that our trucks are going to be passed through. 
/// </summary>
    public class DestinationCountry
    {
        /// <summary>
    /// destanation point 
    /// </summary>
        public string destination { get; set; } = "";
        /// <summary>
        /// list of the countries in order to reach to the destination point.
        /// </summary>
        public List<string> list { get; set; } = new List<string>(10);
    }
}