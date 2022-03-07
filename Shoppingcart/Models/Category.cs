using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shoppingcart.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Product> Product { get; set; }    //Navigation property
    }
}
