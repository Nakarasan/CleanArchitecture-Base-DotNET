using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Purchases
{
    public class PurchaseReturn
    {
        public int Id { get; set; }
        public DateTime PurchaseReturnDate { get; set; }
        public int Qty { get; set; }
        public string? Reason { get; set; }

        public ProductVariant ProductVariant { get; set; }
    }
}
