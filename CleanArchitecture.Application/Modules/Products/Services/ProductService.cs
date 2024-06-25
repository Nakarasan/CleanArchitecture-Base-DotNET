using AutoMapper;
using CleanArchitecture.Application.Modules.Products.Extensions;
using CleanArchitecture.Application.Modules.Products.Models.Request;
using CleanArchitecture.Application.Modules.Products.Models.Response;
using CleanArchitecture.Domain.Entity;
using CleanArchitecture.Domain.Entity.Products;
using CleanArchitecture.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Shared.Common.Helper.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Modules.Products.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDataContext dataContext;
        private readonly IMapper mapper;

        public ProductService(ApplicationDataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async Task<ResponseResult<List<AllProductVM>>> GetAllProductsAsync()
        {

            var products = await dataContext.Products
                .Include(x => x.Category)
                .Select(x => new AllProductVM()
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    IsEnable = x.IsEnable,
                    Tags = x.Tags,
                    CategoryId = x.CategoryId,
                    Description = x.Category.Description

                }).ToListAsync();

            return new ResponseResult<List<AllProductVM>>()
            {
                Errors = null,
                Result = products,
                Succeeded = true
            };
        }
        async Task<ResponseResult<ProductVM>> IProductService.GetProductByIdAsync(int id)
        {
            var product = await dataContext.Products
                .Include(x => x.Category)
                .Where(x=> x.Id == id)
                .Select(x => new ProductVM()
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    IsEnable = x.IsEnable,
                    Tags = x.Tags,
                    CategoryId = x.CategoryId,
                    Description = x.Category.Description
                }).FirstOrDefaultAsync();
            return new ResponseResult<ProductVM>()
            {
                Errors = null,
                Result = product,
                Succeeded = true
            };
        }

        public async Task<ResponseResult<int>> CreateProductAsync(ProductRequest request)
        {
            try
            {
                if (!dataContext.Products.Where(x => x.Id == request.Id).Any())
                {
                    var products = request.ToEntityModel();

                    var check = dataContext.Products.Any();

                    if (check)
                    {
                        var estaff = dataContext.Products.Select(x => x).OrderBy(x => x.Id).Last();
                        products.Id = request.Id;
                    }

                    //save staff table
                    await dataContext.Products.AddAsync(products);
                    await dataContext.SaveChangesAsync();

                    return new ResponseResult<int>()
                    {
                        Errors = null,
                        Result = products.Id,
                        Succeeded = true
                    };
                }
                else
                {
                    return new ResponseResult<int>()
                    {
                        Errors = new[] { "ProductId already exists." },
                        Result = 0,
                        Succeeded = false
                    };
                }
            }
            catch (Exception e)
            {
                return new ResponseResult<int>()
                {
                    Errors = new[] { e.Message },
                    Result = 0,
                    Succeeded = false
                };
            }
        }


        public async Task<ResponseResult<bool>> UpdateProductAsync(int id, ProductUpdateRequest request)
        {
            try
            {
                var staffEnt = await dataContext.Products.FindAsync(id);

                if (staffEnt == null)
                    return new ResponseResult<bool>()
                    {
                        Errors = new[] { "No Product Found!" },
                        Result = true,
                        Succeeded = false
                    };

                var staffs = request.ToEntityModel(staffEnt);

                /*staffs.SetCreatedTime();*/

                //update staff table
                dataContext.Products.Update(staffs);
                await dataContext.SaveChangesAsync();

                return new ResponseResult<bool>()
                {
                    Errors = null,
                    Result = true,
                    Succeeded = true
                };
            }
            catch (Exception e)
            {

                var s = e.Message;
                return new ResponseResult<bool>()
                {
                    Errors = null,
                    Result = false,
                    Succeeded = false
                };

            }
        }


    }
}
