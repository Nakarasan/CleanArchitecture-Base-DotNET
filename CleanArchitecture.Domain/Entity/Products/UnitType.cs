using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Products
{
    public class UnitType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ShortForm { get; set; }
        public bool IsActive { get; set; }
    }
}
