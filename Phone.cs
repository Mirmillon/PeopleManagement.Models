using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class Phone : CountryTelephoneNumber
    {
        int phoneId;
 

        public int PhoneId { get => phoneId; set => phoneId = value; }
      


    }
}
