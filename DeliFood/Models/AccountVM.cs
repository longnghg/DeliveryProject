using System;
using System.ComponentModel.DataAnnotations;

namespace DeliFood.Models
{
    public class AccountVM
    {
        [Key]
        public int AccountId { get; set; }
        [Required]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        [MaxLength(100, ErrorMessage = "Email contains up to 100 characters")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required]
        [MinLength(5, ErrorMessage = "At least 5 characters")]
        [MaxLength(50, ErrorMessage = "Password contains up to 50 characters")]
        public string Pass { get; set; }
        [Display(Name = "Re-Password")]
        [Compare("Pass",ErrorMessage ="The password not match")]
        public string Repass { get; set; }
    }
}
