using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class PhoneUser
    {
        int personId;
        int mobileId;
        Use use;
        bool mainNumber;

        public int PersonId { get => personId; set => personId = value; }
        public int MobileId { get => mobileId; set => mobileId = value; }
        public Use Use { get => use; set => use = value; }
        public bool MainNumber { get => mainNumber; set => mainNumber = value; }
    }
}
