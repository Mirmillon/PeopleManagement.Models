using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    class Landline : LandlinePhone
    {
        int landlineId;
        string phone

        public int LandlineId { get => landlineId; set => landlineId = value; }
    }
}
