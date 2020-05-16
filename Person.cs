using PeopleManagement.Models.EnumTable;
using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleManagement.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display (Name= "Person ID")]
        public int PersonId { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string FirstName
        {
            get
            { return SearchFirstName(firstName); }

            set
            {
                firstName = value.Trim();
            }
        }

        [Display(Name = "Middle name")]
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
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get => lastName; set => lastName = value.Trim(); }
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get ; set ; }
        [Display(Name = "Alive ?")]
        public char? Alive { get; set; }
        [Display(Name = "Date of Dead")]
        public DateTime? DateOfDead { get; set; }
        [Display(Name = "Picture")]
        public string PicturePath { get; set; }
       





        public Person()
        {
            Alive = 'Y';
        }

        string firstName;
        string middleName;
        string lastName;

        private string SearchFirstName (string s)
        {
            char[] delims = new char[] { ' ' };
            string[] prenoms = s.Split(delims);
            return prenoms[0];
        }

        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<Email> Emails { get; set; }
        public List<PhoneUser> PhoneUsers { get; set; }
        public List<Home> Homes { get; set; }
        public List<LanguagePerson> LanguagePersons { get; set; }

        [Display(Name = "Gender")]
        public int GenderId { get; set; }
        public Gender gender { get; set; }





    }
}
