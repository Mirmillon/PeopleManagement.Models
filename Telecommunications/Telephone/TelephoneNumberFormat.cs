using PeopleManagement.Models.EnumTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.RegularExpressions;

namespace PeopleManagement.Models.Telecommunications
{
    public class TelephoneNumberFormat
    {//TABBLE DE JONCTION
        
        [Required]
        [Display(Name = "Digit number")]
        [MaxLength(2)]
        public short Numberdigit { get ; set ; }
        [Display(Name = "Display Format")]
        [DataType(DataType.Text)]
        public string DisplayFormat { get; set; }
        [NotMapped]
        public Regex Display { get => display; set => display = value; }
        Regex display;
        //FK
        [Required]
        [Display(Name = "Country Code")]
        [MaxLength(2)]
        [DataType(DataType.Text)]
        public string CountryId { get; set; }
        public Country Country { get; set; }

        [Required]
        [Display(Name = "Kind Code")]
        public int NumberKindId { get; set; }
        public NumberKind NumberKind { get; set; }









    }
}
