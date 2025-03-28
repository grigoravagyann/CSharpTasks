using System.ComponentModel.DataAnnotations;

namespace Shop.Models.Requests.User
{
    public class UpdateUserRequest
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
