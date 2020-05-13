using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class MobilePhone : TelephoneNumber
    {
        public MobilePhone()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.Mobile;
        }
    }
}
