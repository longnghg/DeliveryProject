using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliFood.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ShipDate { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity not valid")]
        public int Quantity { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Discount not valid")]
        public int Discount { get; set; }
        [Required]
        [Range(1, float.MaxValue, ErrorMessage = "Total price not valid")]
        public float TotalPrice { get; set; }
        [Required]
        [Range(0, 30, ErrorMessage = "VAT is not valid")]
        public float VAT { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        // Navigation property
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
