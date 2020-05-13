using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
   public abstract class LandlinePhone : TelephoneNumber
    {
        
        public LandlinePhone()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.Landline;      
        }
    }
}
