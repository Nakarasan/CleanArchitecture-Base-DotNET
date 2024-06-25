using CleanArchitecture.Domain.Entity.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Advertisements
{
    public class Advertisement
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Brand Brands { get; set; }
    }
}
