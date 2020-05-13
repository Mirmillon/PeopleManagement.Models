using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
   public abstract class LandlinePhone : CountryTelephoneNumber
    {
        
        public LandlinePhone()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.Landline;      
        }
    }
}
