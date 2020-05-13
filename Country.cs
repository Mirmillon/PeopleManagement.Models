using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public class Country
    {
        string codeISO156A2;
        string codeISO156A3;
        short codeISO156C;
        string nameCountry;
        string pathFlag;
        string  telephonePrefix;
 
        IEnumerable<CountryMobileNumber> countryTelephoneNumbers;
        //TODO    2 letters
        public string CodeISO156A2 { get => codeISO156A2; set => codeISO156A2 = value; }
        public string NameCountry { get => nameCountry; set => nameCountry = value; }
        public string PathFlag { get => pathFlag; set => pathFlag = value; }
        public  IEnumerable<CountryMobileNumber> TelephoneNumbers { get => countryTelephoneNumbers; set => countryTelephoneNumbers = value; }
        //TODO    3 letters        
        public string CodeISO156A3 { get => codeISO156A3; set => codeISO156A3 = value; }
        //TODO    3 digits
        public short CodeISO156C { get => codeISO156C; set => codeISO156C = value; }
        public string  TelephonePrefix { get => telephonePrefix; set => telephonePrefix = value; }
    }
}
