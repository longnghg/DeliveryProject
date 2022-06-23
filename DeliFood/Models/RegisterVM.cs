using System;
using System.ComponentModel.DataAnnotations;

namespace DeliFood.Models
{
    public class RegisterVM
    {
        [Required]
        [MinLength(5, ErrorMessage = "Full name at least 5 characters")]
        [MaxLength(50,ErrorMessage ="Full name contains 50 characters")]
        public string Fullname { get; set; }
        [MaxLength(15)]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{4}-? *-?\d{3}", ErrorMessage = "Not a valid Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Fill your username")]
        [MinLength(15, ErrorMessage = "Email at least 15 characters")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        [MaxLength(100, ErrorMessage = "Email contains up to 100 characters")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Fill your password")]
        [MinLength(5, ErrorMessage = "Password at least 5 characters")]
        [MaxLength(50, ErrorMessage = "Password contains 50 characters")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="The password not match")]
        public string RePassword { get; set; }
    }
}
