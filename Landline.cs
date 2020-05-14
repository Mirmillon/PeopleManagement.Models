using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class Landline : LandlineNumber
    {
        int landlineId;
        TelephoneConfidentiality confidentiality;


        public int LandlineId { get => landlineId; set => landlineId = value; }
        public TelephoneConfidentiality Confidentiality { get => confidentiality; set => confidentiality = value; }
    }
}
