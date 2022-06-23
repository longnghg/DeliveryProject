using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace DeliFood.Models
{

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [MinLength(3, ErrorMessage ="Product at least 3 characters")]
        [MaxLength(50, ErrorMessage = "Product name contains up to 50 characters")]
        public string ProductName { get; set; }
        [Required]
        [Range(1, float.MaxValue, ErrorMessage = "Price not valid")]
        public float Price { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Unit in stock not valid")]
        public int UnitInStock { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Image { get; set; }

        public bool IsDelete { get; set; }


        [ForeignKey("Category")]
        public int CatId { get; set; }
        [NotMapped]
        [Required(ErrorMessage ="Please choose image")]
        public IFormFile FileImage { get; set; }

        [NotMapped]
        public IFormFile UpdateImage { get; set; }

        [NotMapped]
        [Range(1, int.MaxValue, ErrorMessage = "Unit in stock not valid")]
        public int QuantityMore { get; set; }

        //Navigation property
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Category Category { get; set; }
    }
}
