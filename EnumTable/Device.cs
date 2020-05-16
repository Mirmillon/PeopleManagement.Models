using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models.EnumTable
{
    public class Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeviceId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Device")]
        [MaxLength(15)]
        public string Label { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
