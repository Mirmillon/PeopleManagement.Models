using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class Mobile :CountryMobileNumber
    {
        int mobileId;
       
        public int MobileId { get => mobileId; set => mobileId = value; }
      


    }
}
