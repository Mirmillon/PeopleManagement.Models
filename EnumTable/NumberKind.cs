using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models.EnumTable
{
    public class NumberKind
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumberKindId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Number Kind")]
        [MaxLength(15)]
        public string Label { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<TelephoneNumberFormat> TelephoneNumberFormats { get; set; }
    }
}
