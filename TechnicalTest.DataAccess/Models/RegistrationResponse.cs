
using System.ComponentModel.DataAnnotations;

namespace TechnicalTest.DataAccess.Models
{
    public class RegistrationResponse
    {
        [Key]
        public string RegistrationId { get; set; }
    }
}
