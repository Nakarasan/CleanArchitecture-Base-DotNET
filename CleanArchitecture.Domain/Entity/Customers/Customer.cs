using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entity.Orders;
using CleanArchitecture.Domain.Entity.Reviews;
using CleanArchitecture.Domain.Entity.ShoppingCart;
using CleanArchitecture.Domain.Entity.Wishlists;

namespace CleanArchitecture.Domain.Entity.Customers
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        public DateOnly Dob { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public CustomerType CustomerType { get; set; }
        public ICollection<ContactDetail> ContactDetails { get; set; }
        public Cart cart { get; set; }
        public ICollection<Order> Orders { get; set; }
        public WishList WishList { get; set; }
    }
}
