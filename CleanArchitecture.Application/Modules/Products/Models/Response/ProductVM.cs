using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Modules.Products.Models.Response
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public bool IsEnable { get; set; }
        public string? Tags { get; set; }
        public int? CategoryId { get; set; }
        public string? Description { get; set; }
    }
}
