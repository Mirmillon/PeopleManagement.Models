using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleManagement.Models.EnumTable
{
    class EnumClasseBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Label { get; set; }
    }
}
