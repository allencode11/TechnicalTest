
using System.ComponentModel.DataAnnotations;

namespace TechnicalTest.DataAccess.Models
{
    public class Organization
    {
        [Required]
        public Address Address { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(120)]
        public string Name { get; set; }
    }
}
