using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Discounts
{
    public class Discount
    {
        public int Id { get; set; }
        public float Persentage { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
    }
}
