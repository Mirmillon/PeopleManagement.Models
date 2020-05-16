using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models.EnumTable
{
    public class Use
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UseId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Using")]
        [MaxLength(15)]
        public string Label { get; set; }

        List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
