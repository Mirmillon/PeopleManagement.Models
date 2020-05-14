using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class MobileNumber 
    {
      
        string phoneNumber;
        TelephoneNumberKind numberKind;

        public MobileNumber()
        {
            numberKind = TelephoneNumberKind.Mobile;
        }

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

       
    }
}
