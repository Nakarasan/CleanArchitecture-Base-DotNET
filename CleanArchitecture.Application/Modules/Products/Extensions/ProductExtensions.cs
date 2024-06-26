using CleanArchitecture.Application.Modules.Products.Commands;
using CleanArchitecture.Application.Modules.Products.Models.Request;
using CleanArchitecture.Domain.Entity.Products;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CleanArchitecture.Application.Modules.Products.Extensions
{
    public static class ProductExtensions
    {
        //to create
        public static ProductRequest ToServiceRequest(this CreateProductCommand command)
        {
            var product = new ProductRequest()
            {
                Id = command.Id,
                ProductName = command.ProductName,
                IsEnable = command.IsEnable,
                Tags = command.Tags,
                CategoryId = command.CategoryId,    
                SubCategoryId = command.SubCategoryId,
                BrandId = command.BrandId,
                WarrantyId  = command.WarrantyId,
                ManufacturerId = command.ManufacturerId,
            };
            return product;
        }

        //to create
        public static Product ToEntityModel(this ProductRequest request)
        {
            var product = new Product()
            {
                Id = request.Id,
                ProductName = request.ProductName,
                IsEnable = request.IsEnable,
                Tags = request.Tags,
                CategoryId= request.CategoryId,
                SubCategoryId = request.SubCategoryId,
                BrandId = request.BrandId,
                WarrantyId = request.WarrantyId,
                ManufacturerId = request.ManufacturerId,
            };
            return product;
        }

        //for update
        public static ProductUpdateRequest ToServiceRequest(this UpdateProductCommand command)
        {
            var product = new ProductUpdateRequest()
            {
                Id = command.Id,
                ProductName = command.ProductName,
                IsEnable = command.IsEnable,
                Tags = command.Tags,
                CategoryId = command.CategoryId,
                SubCategoryId = command.SubCategoryId,
                BrandId = command.BrandId,
                WarrantyId = command.WarrantyId,
                ManufacturerId = command.ManufacturerId,
            };
            return product;
        }

        //for update
        public static Product ToEntityModel(this ProductUpdateRequest request, Product p)
        {
            p.Id = request.Id;
            p.ProductName = request.ProductName ?? p.ProductName;
            p.IsEnable = request.IsEnable ;
            p.Tags = request.Tags ?? p.Tags;
            p.CategoryId = request.CategoryId ;
            p.SubCategoryId = request.SubCategoryId;
            p.BrandId = request.BrandId;
            p.WarrantyId = request.WarrantyId;
            p.ManufacturerId = request.ManufacturerId;

            return p;
        }
        
        //for Image 
        public static void SetProductImage(this Product product, string image = "")
        {
            product.Tags = image;
        }
    }
}
