using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PeopleManagement.Models.Telecommunications
{
    public class ServicesPhone : CountryTelephoneNumber
    {
        public ServicesPhone()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.Services;
        }
    }
}
