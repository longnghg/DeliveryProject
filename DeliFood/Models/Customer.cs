using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliFood.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
        [MaxLength(15)]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{4}-? *-?\d{3}", ErrorMessage = "Not a valid Phone Number")]
        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string FullName { get; set; }

        public bool Status { get; set; }
        [ForeignKey("Account")]
        public int AccountID { get; set; }

        //Navigation property
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Account Account { get; set; }


    }
}
