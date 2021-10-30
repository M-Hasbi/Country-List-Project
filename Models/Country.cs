using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Country_List_Project.Models
{
    public class Country
    {
        public List<string> countryCodes { get; set; } = new List<string>(10);

       
    }
}