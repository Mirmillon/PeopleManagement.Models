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
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public char Alive { get => alive; set => alive = value; }
        public DateTime DateOfDead { get => dateOfDead; set => dateOfDead = value; }
        public string PicturePath { get => picturePath; set => picturePath = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public Phone Phone { get => phone; set => phone = value; }
    }
}
