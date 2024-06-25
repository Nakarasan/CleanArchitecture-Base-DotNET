using CleanArchitecture.Domain.Entity.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Wishlists
{
    public class WishList
    {
        public int Id { get; set; }

        public Cart Cart { get; set; }
        public ICollection<ProductVarientWishlist> ProductVarientWishlist { get; set; }
    }
}
