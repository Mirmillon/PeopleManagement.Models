using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PeopleManagement.Models.Telecommunications
{
    public class Mobile : CountryTelephoneNumber
    {
        public Mobile()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.Mobile;
        }
    }
}
