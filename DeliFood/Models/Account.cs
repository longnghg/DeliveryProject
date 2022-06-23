using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliFood.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100, ErrorMessage = "Email contains up to 100 characters")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50, ErrorMessage = "Password contains up to 50 characters")]
        public string Pass { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime CreateDate { get; set; }


        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string Role { get; set; }

        // Navigation property
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
