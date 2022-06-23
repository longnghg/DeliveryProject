using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliFood.Models
{
    public class Order
    {
        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [Column(TypeName = "nvarchar(255)", Order = 2)]
        [MaxLength(255)]
        public string Note { get; set; }
        [Column(TypeName = "float", Order = 3)]
        [Range(0, float.MaxValue, ErrorMessage = "The value not valid")]
        public float TotalPrice { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]    
        public DateTime OrderDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        //Navigation property
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
