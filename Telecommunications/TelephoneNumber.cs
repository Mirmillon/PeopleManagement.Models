using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PeopleManagement.Models.Telecommunications
{
    public abstract class TelephoneNumber
    {       
        short numberdigit;
        string phoneNnumber;
        Regex display;
        TelephoneNumberKind telephoneNumberKind;
       
        public short Numberdigit { get => numberdigit; set => numberdigit = value; }
        public string PhoneNumber { get => phoneNnumber; set => phoneNnumber = value; }
        public Regex Display { get => display; set => display = value; }
        public TelephoneNumberKind TelephoneNumberKind { get => telephoneNumberKind; set => telephoneNumberKind = value; }
    }
}
