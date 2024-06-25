using AutoMapper;
using CleanArchitecture.Application.Modules.Products.Models.Response;
using CleanArchitecture.Application.Modules.Products.Services;
using CleanArchitecture.Domain.Entity;
using MediatR;
using Shared.Common.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Modules.Products.Queries
{
    public class GetAllProductQuery : IRequest<ResponseResult<List<AllProductVM>>>
    {
    }

    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, ResponseResult<List<AllProductVM>>>
    {
        private readonly IProductService productService;

        public GetAllProductQueryHandler(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task<ResponseResult<List<AllProductVM>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await productService.GetAllProductsAsync();
        }
    }


    /* public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<ProductVM>>
     {
         private readonly IProductService productService;
         private readonly IMapper mapper;

         public GetProductQueryHandler(IProductService productService, IMapper mapper)
         {
             this.productService = productService;
             this.mapper = mapper;
         }

         public async Task<List<ProductVM>> Handle(GetProductQuery request, CancellationToken cancellationToken)
         {
             var products = await productService.GetAllProductsAsync();

             var productList = products.Select(x => new ProductVM
             { Id = x.Id, ProductName = x.ProductName, IsEnable = x.IsEnable, Tags = x.Tags }).ToList();
             return productList;
         }
     }*/
}
