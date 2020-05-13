using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class Phone
    {
        int phoneId;
        string phoneNumber;

        public int PhoneId { get => phoneId; set => phoneId = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
