using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shoppingcart.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey(nameof(Cart.Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        [ForeignKey(nameof(Cart.User))]
        public Guid UserId { get; set; }
        public MyIdentityUser User { get; set; }

        public int Quantity { get; set; }

    }
}
