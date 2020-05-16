using PeopleManagement.Models.EnumTable.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class LanguageCountry
    {
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public string CountryId { get; set; }
        public Country Country { get; set; }
    }
}
