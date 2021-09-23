
using TechnicalTest.DataAccess.Models;

namespace TechnicalTest.Models
{
    public class ErrorResponse
    {
        public Error Error{ get; set; }
        public FieldError?[] FieldError{ get; set; }
    }
}
