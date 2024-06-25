using CleanArchitecture.Domain.Entity.Purchases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Products
{
    public class Stock
    {
        public int Id { get; set; }
        public DateTime UpdateTime { get; set; }
        public int AvailableStock { get; set; }
        public Purchase Purchase { get; set; }
        public PurchaseReturn PurchaseReturn { get; set; }
        public ProductVariant ProductVariant { get; set; }
    }
}
