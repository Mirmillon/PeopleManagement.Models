using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PeopleManagement.Models.Telecommunications
{
    public class CountryLandlineNumber : LandlinePhone
    {
        string internationalPrefix;
        string phoneNumber;

        public CountryLandlineNumber():base()
        {

        }

        public CountryLandlineNumber(Country c):base()
        {
            internationalPrefix = c.TelephonePrefix;
        }

        public CountryLandlineNumber(Country c, string n) : base()
        {
            internationalPrefix = c.TelephonePrefix;
            phoneNumber = n;
        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public string InternationalPrefix { get => internationalPrefix; set => internationalPrefix = value; }
    }
}
