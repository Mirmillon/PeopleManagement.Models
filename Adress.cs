using PeopleManagement.Models.EnumTable.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models
{
    public class Adress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Adress ID")]
        public int AdressId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Line 1")]
        [MaxLength(35)]
        public string Line1 { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Line 2")]
        [MaxLength(35)]
        public string Line2 { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Line 3")]
        [MaxLength(35)]
        public string Line3 { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Postal Code")]
        [MaxLength(12)]
        public string ZipCode { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        [MaxLength(29)]
        public string City { get; set; }

        public int AdressKindId { get; set; }
        public AdressKind AdressKind { get; set; }

        public List<Home> Homes { get; set; }



    }
}
