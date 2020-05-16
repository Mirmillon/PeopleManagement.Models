using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models
{
    public class Home
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Home ID")]

        public int HomeId { get; set; }
        [Display(Name = "Main Home")]       
        public bool MainHome { get; set; }
        public int AdressId { get; set; }
        public Adress Adress { get; set; }
        //FK
        public int personId { get; set; }
        public Person Person { get; set; }

        public List<HomeCountry> HomeCountries { get; set; }
       
    }
}
