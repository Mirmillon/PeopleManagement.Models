using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleManagement.Models.EnumTable.People
{
    public class LanguageLevel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LanguageLevelId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Language Level")]
        [MaxLength(15)]
        public string Label { get; set; }

        public List<LanguagePerson> LanguagePersons { get; set; }
}
}
