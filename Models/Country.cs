using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Country_List_Project.Models
{/// <summary>
/// The list of 3 letters codes of the countries that our trucks are able to travel through
/// </summary>
    public class Country
    {/// <summary>
    /// 3 letters of the country codes
    /// </summary>
        public List<string> countryCodes { get; set; } = new List<string>(10);
        


    }
}