using CleanArchitecture.Domain.Entity.Customers;
using CleanArchitecture.Domain.Entity.Discounts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Orders
{
    public class Order
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? OrderNumber { get; set; }
        [MaxLength(50)]
        public string? Status { get; set; }
        public double TotalAmount { get; set; }
        public double NetAmount { get; set; }
        public DateTime DateAndTime { get; set; }
        public Customer Customers { get; set; }
        public Discount Discount { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
