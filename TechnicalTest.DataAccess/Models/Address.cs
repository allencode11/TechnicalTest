
using System.ComponentModel.DataAnnotations;

namespace TechnicalTest.DataAccess.Models
{
    public class Address
    {
        [Key]
        [MaxLength(150)]
        [MinLength(1)]
        [Required]
        public string AddressLine1 { get; set; }

        [MaxLength(150)]
        [MinLength(1)]
        public string AddressLine2 { get; set; }

        [MaxLength(150)]
        [MinLength(1)]
        public string AddressLine3 { get; set; }

        [MaxLength(40)]
        public string City { get; set; }

        [MinLength(1)]
        [Required]
        public string CountryIsoCode { get; set; }

        public string Locale { get; set; }
        
        [MaxLength(60)]
        public string Postcode { get; set; }

        [MaxLength(60)]
        public string State { get; set; }
    }
}
