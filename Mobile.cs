using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class Mobile : MobileNumber
    {
        int mobileId;
        int countryId;
        int ownerId;
        TelephoneConfidentiality confidentiality;
       
        public int MobileId { get => mobileId; set => mobileId = value; }
        public int CountryId { get => countryId; set => countryId = value; }
    }
}
