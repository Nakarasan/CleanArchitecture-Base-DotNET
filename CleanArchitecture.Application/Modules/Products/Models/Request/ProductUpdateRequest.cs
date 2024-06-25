using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Modules.Products.Models.Request
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public bool IsEnable { get; set; }
        public string? Tags { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int BrandId { get; set; }
        public int WarrantyId { get; set; }
        public int ManufacturerId { get; set; }
    }
}
