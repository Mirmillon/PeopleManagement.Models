using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class TollFreeNumber
    {
        TelephoneNumberKind numberKind;
        string phoneNumber;
        public TollFreeNumber()
        {
            numberKind = TelephoneNumberKind.TollFree;
        }

       
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

      
    }
}
