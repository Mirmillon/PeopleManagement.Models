using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class MobilePhone : CountryTelephoneNumber
    {
        public MobilePhone()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.Mobile;
        }
    }
}
