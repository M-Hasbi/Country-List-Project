using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Country_List_Project.Models
{
    public class DestinationCountry
    {
        public string destination { get; set; } = "";
        public List<string> list { get; set; } = new List<string>(10);
    }
}