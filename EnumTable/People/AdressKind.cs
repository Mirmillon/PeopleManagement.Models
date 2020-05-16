using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models.EnumTable.People
{
    public class AdressKind
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdressKindId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Adresse Kind")]
        [MaxLength(15)]
        public string Label { get; set; }

        public List<Adress> Adresses { get; set; }
    }
}
