using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shoppingcart.Models;
using System;

namespace Shoppingcart.Data
{
    public class ApplicationDbContext 
        : IdentityDbContext<MyIdentityUser, MyIdentityRole, Guid>
    { 
        public DbSet<MyIdentityUser> MyIdentityUsers { get; set; }
        public DbSet<MyIdentityRole> MyIdentityRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart>Cart { get; set; }
        public DbSet<Order> Orders { get; set; }
        
   
    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
