using PeopleManagement.Models.EnumTable;
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
        [Display(Name = "Confidentiality")]
        public Confidentiality Confidentiality  { get; set; }
        
        public int DeviceId { get; set; }
        [Display(Name = "Device")]
        public EnumTable.Device Device { get; set; }
        
        public int NumberKindId { get; set; }
        [Display(Name = "Number Kind")]
        public NumberKind NumberKind { get; set; }

        public int UseId { get; set; }
        [Display(Name = "Using")]
        public EnumTable.Use Use { get; set; }

        public List<PhoneUser> PhoneUsers { get; set; }



    }
}
