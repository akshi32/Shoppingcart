using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Shoppingcart.Models
{
    public class MyIdentityUser
        : IdentityUser<Guid>
    {
        [Display(Name = "PhoneNumber")]
        //[Required]
        [MinLength(10, ErrorMessage = "{0} must have {1} digit")]
        [RegularExpression(@"7|8|9\d{9}", ErrorMessage = "{0} must begin with 7,8 or 9")]
        
        public string PhoneNumber { get; set; }

       
        [Display(Name = "DateOfBirth")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }

        public ICollection<Cart> Carts { get; set; } //Navigation Property

        public ICollection<Order> Order { get; set; } //Navigation Property

        

    }
}
