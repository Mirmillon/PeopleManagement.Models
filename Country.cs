using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public class Country
    {
        string codeCountry;
        string nameCountry;
        string pathFlag; 
 
        IEnumerable<CountryTelephoneNumber> countryTelephoneNumbers;

        public string CodeCountry { get => codeCountry; set => codeCountry = value; }
        public string NameCountry { get => nameCountry; set => nameCountry = value; }
        public string PathFlag { get => pathFlag; set => pathFlag = value; }
        public  IEnumerable<CountryTelephoneNumber> TelephoneNumbers { get => countryTelephoneNumbers; set => countryTelephoneNumbers = value; }

        private void 
    }
}
