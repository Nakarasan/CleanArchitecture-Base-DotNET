using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Orders
{
    public class OrderReturn
    {
        public int Id { get; set; }
        public DateOnly ReturnDate { get; set; }
        public string? Reason { get; set; }
        public int Qty { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
