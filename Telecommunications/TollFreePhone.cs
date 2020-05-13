using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class TollFreePhone: TelephoneNumber
    {
        public TollFreePhone()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.TollFree;
        }
    }
}
