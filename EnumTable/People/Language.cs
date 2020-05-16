using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleManagement.Models.EnumTable.People
{
    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LanguageId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Language")]
        [MaxLength(20)]
        public string Label { get; set; }

        public List<LanguageCountry> LanguageCountries { get; set; }
        public List<LanguagePerson> LanguagePersons { get; set; }
    }
}
