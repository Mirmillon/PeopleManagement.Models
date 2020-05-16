using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models.EnumTable
{
    public class Confidentiality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  ConfidentialityId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Confidentiality")]
        [MaxLength(30)]
        public string Label { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
