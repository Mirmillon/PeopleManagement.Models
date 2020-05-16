using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models
{
    public class Email
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmailId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Label { get; set; }
        public bool MainEmail { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
