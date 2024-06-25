using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Products
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public string? Tags { get; set; }
        [MaxLength(150)]
        public string? Description { get; set; }

        public ICollection<Product>? Product { get; set; }
        public ICollection<SubCategory> SubCategorie { get; set; }
    }
}
