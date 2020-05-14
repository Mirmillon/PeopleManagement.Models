using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class ServicePhone : ServicesNumber
    {
        int servicePhoneId;
        TelephoneConfidentiality confidentiality;

        public int ServicePhoneId { get => servicePhoneId; set => servicePhoneId = value; }
        public TelephoneConfidentiality Confidentiality { get => confidentiality; set => confidentiality = value; }
    }
}
