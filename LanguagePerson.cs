using PeopleManagement.Models.EnumTable.People;
using System.ComponentModel.DataAnnotations;

namespace PeopleManagement.Models
{
    public class LanguagePerson
    {
        [Display(Name = "Language Level")]
        public int LanguageLevelId { get; set; }

        public LanguageLevel LanguageLevel { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
