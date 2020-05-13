using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class CountryMobileNumber : MobilePhone
    {

        string internationalPrefix;
        string phoneNumber;
      

        public CountryMobileNumber(Country c):base()
        {
            internationalPrefix = c.TelephonePrefix;
        }


        public CountryMobileNumber(Country c, string  n) : base()
        {
            internationalPrefix = c.TelephonePrefix;
            phoneNumber = n;
        }


        public CountryMobileNumber():base()
        {

        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public string InternationalPrefix { get => internationalPrefix; set => internationalPrefix = value; }
       

       
    }
}
