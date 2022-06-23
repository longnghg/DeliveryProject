using System;
namespace DeliFood.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int  amount { get; set; }
        public double Total => (double)amount * Price;

    }
}
