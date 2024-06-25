using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Qauantity { get; set; }
        public Order Order { get; set; }
        public ProductVariant ProductVariants { get; set; }
        public OrderReturn orderReturn { get; set; }
    }
}
