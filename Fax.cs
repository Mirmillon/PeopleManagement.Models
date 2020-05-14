using PeopleManagement.Models.Telecommunications;
using PeopleManagement.Models.Telecommunications.Telephone;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class Fax : FaxNumber
    {
        int countryID;
        int faxId;
        TelephoneConfidentiality confidentiality;

        public int FaxId { get => faxId; set => faxId = value; }
        public int CountryID { get => countryID; set => countryID = value; }
        public TelephoneConfidentiality Confidentiality { get => confidentiality; set => confidentiality = value; }
    }
}
