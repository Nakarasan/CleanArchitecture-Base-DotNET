using CleanArchitecture.Application.Modules.Products.Models.Request;
using CleanArchitecture.Application.Modules.Products.Models.Response;
using CleanArchitecture.Domain.Entity;
using CleanArchitecture.Domain.Entity.Products;
using Microsoft.AspNetCore.Http;
using Shared.Common.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Modules.Products.Services
{
    public interface IProductService
    {
        Task<ResponseResult<List<AllProductVM>>> GetAllProductsAsync();
        Task<ResponseResult<ProductVM>> GetProductByIdAsync(int id);
        Task<ResponseResult<int>> CreateProductAsync(ProductRequest request);
        Task<ResponseResult<bool>> UpdateProductAsync(int Id,ProductUpdateRequest request);
        Task<ResponseResult<bool>> SetProductImageAsync(int id, IFormFile image);
    }
}
