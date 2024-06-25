using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Wishlists
{
    public class ProductVarientWishlist
    {
        public int wishListId { get; set; }
        public WishList wishList { get; set; }
        public int productVariantsId { get; set; }
        public ProductVariant productVariant { get; set; }
    }
}
