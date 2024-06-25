using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Offers
{
    public class Offer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Percentage { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductOffer> ProductOffers { get; set; }
    }
}
