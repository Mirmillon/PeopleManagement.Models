using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class ServicesPhone : TelephoneNumber
    {
        public ServicesPhone()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.Services;
        }
    }
}
