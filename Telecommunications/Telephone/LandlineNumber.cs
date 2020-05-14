using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
   public abstract class LandlineNumber 
    {

        TelephoneNumberKind numberKind;
        string phoneNumber;
        Device device;



        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

      
        public Device Device { get => device; set => device = value; }

        public LandlineNumber()
        {
            numberKind = TelephoneNumberKind.Landline;
            device = Device.Phone;
        }
    }
}
