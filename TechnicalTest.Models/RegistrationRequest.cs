using System.ComponentModel.DataAnnotations;
using TechnicalTest.DataAccess.Models;

namespace TechnicalTest.Models
{
    class RegistrationRequest
    {
        public string locale { get; set; }

        public Organization Organization { get; set; }

        [Required]
        public Person Person { get; set; }

        [Required]
        public string RegistrationDate { get; set; }
    }
}
