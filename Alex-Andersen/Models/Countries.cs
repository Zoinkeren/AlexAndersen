using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class Countries
    {
        [Key]
        public int CountryID { get; set; }
        [MaxLength(100)]
        public string CountryName { get; set; }
        [MaxLength(2, ErrorMessage = "The Countrycode must be 2 characters"), MinLength(2)]
        public string CountryCode { get; set; }
        [MaxLength(4, ErrorMessage = "The Phonecode must be 4 characters"), MinLength(4)]
        public string PhoneCode { get; set; }
    }
}
