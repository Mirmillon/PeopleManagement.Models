using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public class TollFree: CountryTelephoneNumber
    {
        public TollFree()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.TollFree;
        }
    }
}
