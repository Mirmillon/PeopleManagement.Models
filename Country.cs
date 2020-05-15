using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleManagement.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength (2)]
        [DataType(DataType.Text)]
        [Display(Name = "Country Code")]
        public string CountryId { get; set ; }
        [MaxLength(3)]
        [DataType(DataType.Text)]
        [Display(Name = "Country Code 3A")]
        public string CodeISO156A3 { get; set; }
        [MaxLength(3)]
        [Display(Name = "Country Code 3D")]
        public short? CodeISO156C { get ; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Regular Name")]
        public string NameCountry { get ; set ; }
        [DataType (DataType.Text)]
        [Display(Name = "Path Flag")]
        public string PathFlag { get ; set; }
        [DataType(DataType.Text)]
        [MaxLength(6)]
        [Display(Name = "Phone Prefix")]
        public string TelephonePrefix { get; set ; }


        List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
