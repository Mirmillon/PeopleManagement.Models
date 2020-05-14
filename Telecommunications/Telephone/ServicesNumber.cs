using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class ServicesNumber : TelephoneNumberFormat
    {
        
        string phoneNumber;
        TelephoneNumberKind numberKind;

        public ServicesNumber()
        {
            numberKind = TelephoneNumberKind.Services;
        }


        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        
    }
}
