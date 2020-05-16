using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class PhoneUser
    {


        public bool MainNumber { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int PhoneNumberId { get ; set; }
        public PhoneNumber PhoneNumber { get; set; }




    }
}
