using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Products
{
    public class Manufacturer
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
