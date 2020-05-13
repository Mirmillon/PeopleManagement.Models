using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    class Landline : CountryLandlineNumber
    {
        int landlineId;
        

        public int LandlineId { get => landlineId; set => landlineId = value; }
    }
}
