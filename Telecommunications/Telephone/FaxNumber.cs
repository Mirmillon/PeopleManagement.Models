using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications.Telephone
{
    public class FaxNumber : LandlineNumber
    {
        public FaxNumber():base()
        {
            Device = Device.Fax;
        }
    }
}
