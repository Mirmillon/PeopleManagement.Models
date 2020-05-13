using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public class CountryTelephoneNumber:TelephoneNumber
    {
        short internationalPrefix;

        public short InternationalPrefix { get => internationalPrefix; set => internationalPrefix = value; }
    }
}
