using CleanArchitecture.Domain.Entity.Offers;
using CleanArchitecture.Domain.Entity.Reviews;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Products
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? ProductName { get; set; }
        public bool IsEnable { get; set; }
        public string? Tags { get; set; }
        public Category? Category { get; set; }
        public SubCategory? SubCategory { get; set; }
        public Brand? Brand { get; set; }
        public Warranty? Warranty { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Manufacturer? Manufacturer { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }
        public ICollection<ProductOffer> ProductOffers { get; set; }
        public int? CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int BrandId { get; set; }
        public int WarrantyId { get; set; }
        public int ManufacturerId { get; set; }


        public static implicit operator int(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
