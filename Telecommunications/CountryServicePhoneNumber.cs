using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class CountryServicePhoneNumber :ServicesPhone
    {
        string internationalPrefix;
        string phoneNumber;

        public CountryServicePhoneNumber():base()
        {
                
        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public string InternationalPrefix { get => internationalPrefix; set => internationalPrefix = value; }
    }
}
