
using System.ComponentModel.DataAnnotations;

namespace TechnicalTest.DataAccess.Models
{
    public class Person
    {
        public Address Address { get; set; }
        
        [Key]
        [MaxLength(254)]
        [MinLength(1)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(1)]
        [MaxLength(150)]
        [Required]
        public string FirtName { get; set; }
        
        [MinLength(1)]
        [MaxLength(150)]
        [Required]
        public string LastName { get; set; }
    }
}
