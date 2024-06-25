using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Offers
{
    public class ProductOffer
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OfferId { get; set; }
        public Offer Offers { get; set; }
    }
}
