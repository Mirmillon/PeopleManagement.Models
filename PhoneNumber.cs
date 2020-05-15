using PeopleManagement.Models.Telecommunications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models
{
    public class PhoneNumber 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Phone Number  Id")]
        public int PhoneNumberId { get; set; }
        [Required]
        [Display(Name = "Number")]
        public int Number { get; set; }
       
      
        [Display(Name = "Building Id")]
        public int? BuildingId { get; set; }


        [Display(Name = "Device")]
        public Device Device { get; set; }
        [Display(Name = "Number Kind")]
        public TelephoneNumberKind TelephoneNumberKind { get; set; }

        // FK
        [Display(Name = "Country Code")]
        [MaxLength(2)]
        [DataType(DataType.Text)]
        public string CountryId { get; set; }
        public Country Country { get; set; }

        [Display(Name = "Owner Id")]
        public int? PersonId { get; set; }
        public Person Person { get; set; }

        //TRE
        public int ConfidentialityId { get; set; }
        public Confidentiality Confidentiality  { get; set; }
       




    }
}
