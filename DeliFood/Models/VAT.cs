using System;
using System.ComponentModel.DataAnnotations;

namespace DeliFood.Models
{
    public class VAT
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0,20, ErrorMessage ="Please enter valid number")]
        public float CurrentVAT { get; set; }
    }
}
