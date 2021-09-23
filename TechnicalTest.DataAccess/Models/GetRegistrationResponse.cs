using System.ComponentModel.DataAnnotations;
using TechnicalTest.DataAccess.Models;

namespace TechnicalTest.DataAccess.Models
{
    public class GetRegistrationResponse
    {
        [Key]
        public string Id { get; set; }
        public string Locale { get; set; }
        public Organization Organization { get; set; }

        [Required]
        public Person Person { get; set; }

        [Required]
        public string RegistrationDate { get; set; }
    }
}
