using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication7.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
