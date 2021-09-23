using System.ComponentModel.DataAnnotations;
using TechnicalTest.DataAccess.Models;

namespace TechnicalTest.Models
{
    public class RegistrationRequest
    {
        public string Locale { get; set; }
        public Organization Organization { get; set; }

        [Required]
        public Person Person { get; set; }

        [Required]
        public string RegistrationDate { get; set; }
    }
}
