using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.ShoppingCart
{
    public class ProductVarientCart
    {
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int productVariantsId { get; set; }
        public ProductVariant productVariant { get; set; }
    }
}
