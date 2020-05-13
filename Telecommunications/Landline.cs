using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
   public class Landline : CountryTelephoneNumber
    {
        public Landline()
        {
            base.TelephoneNumberKind = TelephoneNumberKind.Landline;      
        }
    }
}
