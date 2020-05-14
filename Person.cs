using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PeopleManagement.Models
{
    public class Person
    {
        int personId;
        string firstName;
        string middleName;
        string lastName;
        DateTime dateOfBirth;
        char alive;
        DateTime dateOfDead;
        string picturePath;
        Gender gender;
        int  mobileId;
        List<Country> countrieList;
        List<Mobile> mobilesList;
        List<Landline> landlinesList;
       

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { 
            get
            {
                return SearchFirstName(firstName);
            }
            set
            {
                firstName = value.Trim();
            } 
        }
        public string MiddleName
        {
            get => middleName;
            set
            {    // check if there is a middlename 
                if (!String.IsNullOrWhiteSpace(value))
                {
                    value.Trim();
                }
            }
        }
        public string LastName { get => lastName; set => lastName = value.Trim(); }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public char Alive { get => alive; set => alive = value; }
        public DateTime DateOfDead { get => dateOfDead; set => dateOfDead = value; }
        public string PicturePath { get => picturePath; set => picturePath = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public int MobileId { get => mobileId; set => mobileId = value; }
        public List<Country> CountrieList { get => countrieList; set => countrieList = value; }
        public List<Mobile> MobilesList { get => mobilesList; set => mobilesList = value; }
        internal List<Landline> LandlinesList { get => landlinesList; set => landlinesList = value; }
        

        private string SearchFirstName (string s)
        {
            char[] delims = new char[] { ' ' };
            string[] prenoms = s.Split(delims);
            return prenoms[0];
        }
 
        public void SetCountry(string code)
        {
            Country c = new Country();
            c.CodeISO156A2 = code;
            countrieList.Add(c);
        }

        public void SetMobile(Country  c, string number)
        {
            Mobile  m = new Mobile();
            m.InternationalPrefix = c.TelephonePrefix;
            m.PhoneNumber = number;
            mobilesList.Add(m);
        }

        public void SetLandline(Country c, string number)
        {
            Landline l = new Landline();
            l.InternationalPrefix = c.TelephonePrefix;
            l.PhoneNumber = number;
            landlinesList.Add(l);
        }
        
    }
}
