using CleanArchitecture.Domain.Entity.Customers;
using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Reviews
{
    public class Review
    {
        public int Id { get; set; }
        public DateTime DateAndTime { get; set; }
        public double Rateing { get; set; }
        [MaxLength(500)]
        public String? Comments { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
