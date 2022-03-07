using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shoppingcart.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Detalis { get; set; }

        public string Image { get; set; }

        public int size { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        [ForeignKey(nameof(Product.Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Cart> Cart { get; set; } //Navigation property

        public ICollection<Order> Order { get; set; }

    }
}
