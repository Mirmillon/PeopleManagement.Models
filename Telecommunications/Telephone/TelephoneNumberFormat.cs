using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PeopleManagement.Models.Telecommunications
{
    public class TelephoneNumberFormat
    {
        int countryId;
        TelephoneNumberKind telephoneNumberKind;
        short numberdigit;
        Regex display;
        
        string codePays;

       
        public short Numberdigit { get => numberdigit; set => numberdigit = value; }
      
        public Regex Display { get => display; set => display = value; }
        public TelephoneNumberKind TelephoneNumberKind { get => telephoneNumberKind; set => telephoneNumberKind = value; }
        public string CodePays { get => codePays; set => codePays = value; }
        public int CountryId { get => countryId; set => countryId = value; }
    }
}
