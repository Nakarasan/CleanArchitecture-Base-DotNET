using CleanArchitecture.Domain.Entity.Orders;
using CleanArchitecture.Domain.Entity.Wishlists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.ShoppingCart
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime Adddate { get; set; }
        public double TotalAmount { get; set; }

        public Order Order { get; set; }
        public ICollection<WishList> wishLists { get; set; }
        public ICollection<ProductVarientCart> ProductVariantsCart { get; set; }
    }
}
