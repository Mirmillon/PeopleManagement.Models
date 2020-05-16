using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models.EnumTable
{
    public class Gender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenderId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Gender")]
        [MaxLength(15)]
        public string Label { get; set; }

        List<Person> Persons { get; set; }
    }
}
