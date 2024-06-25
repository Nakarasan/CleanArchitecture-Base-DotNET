using CleanArchitecture.Domain.Entity.Orders;
using CleanArchitecture.Domain.Entity.ShoppingCart;
using CleanArchitecture.Domain.Entity.Wishlists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Products
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LongDescription { get; set; }
        public string? Description { get; set; }
        public double? BasicPrice { get; set; }
        public double? SellingPrice { get; set; }
        public DateOnly? ManufactureDate { get; set; }
        public DateOnly? ExpireDate { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public bool IsActive { get; set; }
        public double Tax { get; set; }
        public bool IsDefault { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Product Product { get; set; }

        public OrderReturn OrderReturn { get; set; }
        public VariantUnit VariantUnit { get; set; }
        public VariantColor VariantColor { get; set; }
        public VariantSize VariantSize { get; set; }

        public ICollection<ProductVarientCart> ProductVariantsCart { get; set; }
        public ICollection<ProductVarientWishlist> ProductVariantWishList { get; set; }
    }
}
