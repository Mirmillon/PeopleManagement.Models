using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class HomeCountry
    {
        public string CountryId { get; set; }
        public Country Country { get; set; }

        public int HomeId { get; set; }

        public Home Home { get; set; }

    }
}
