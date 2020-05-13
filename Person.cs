using System;

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
        Phone phone;


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
        public Phone Phone { get => phone; set => phone = value; }

        private string SearchFirstName (string s)
        {
            char[] delims = new char[] { ' ' };
            string[] prenoms = s.Split(delims);
            return prenoms[0];
        }
    }
}
