using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shoppingcart.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey(nameof(Order.Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey(nameof(Order.User))]
        public Guid UserId { get; set; }
        public MyIdentityUser User { get; set; }

        public int Size { get; set; }

        public int Quantity { get; set; }
        
        public int Price { get; set; }

        public int Cost { get; set; }

        public int TotalCost { get; set; }

        public string Status { get; set; }

        




    }
}
