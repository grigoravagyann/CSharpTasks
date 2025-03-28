
using System.ComponentModel.DataAnnotations;

namespace Shop.Models.Requests.User
{
    public class CreateUserRequest
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
