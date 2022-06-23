using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliFood.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        [MaxLength(30, ErrorMessage = "Category name contains up to 30 characters ")]
        public string CatName { get; set; }
        [Required]
        public bool Published { get; set; }


        //Navigation property
        public virtual ICollection<Product> Products { get; set; }
    }
}
