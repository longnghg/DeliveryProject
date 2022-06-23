using System;
using System.ComponentModel.DataAnnotations;

namespace DeliFood.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Fill your username")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [MaxLength(100, ErrorMessage = "Email contains up to 100 characters")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Fill your password")]
        [MaxLength(50, ErrorMessage = "Password contains 50 characters")]
        public string Password { get; set; }
    }
}
