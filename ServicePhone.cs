using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    class ServicePhone : CountryServicePhoneNumber
    {
        int servicePhoneId;

        public int ServicePhoneId { get => servicePhoneId; set => servicePhoneId = value; }
    }
}
