using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models
{
    public class TollFree :CountryTollFreeNumber
    {
        int tollFreeId;

        public int TollFreeId { get => tollFreeId; set => tollFreeId = value; }
    }
}
