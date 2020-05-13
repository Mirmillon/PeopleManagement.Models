using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public class CountryTelephoneNumber:TelephoneNumber
    {
        Country country;
        string phoneNumber;

        public CountryTelephoneNumber(short prefix)
        {
            country.TelephonePrefix = prefix;
        }

        public CountryTelephoneNumber()
        {
            country = new Country();
        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Country Country { get => country; set => country = value; }
    }
}
