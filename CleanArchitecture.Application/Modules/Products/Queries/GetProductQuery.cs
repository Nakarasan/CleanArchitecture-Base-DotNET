using CleanArchitecture.Application.Modules.Products.Models.Response;
using CleanArchitecture.Application.Modules.Products.Services;
using MediatR;
using Shared.Common.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Modules.Products.Queries
{
    public class GetProductQuery : IRequest<ResponseResult<ProductVM>>
    {
        public int Id { get; set; }
    }

    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ResponseResult<ProductVM>>
    {
        private readonly IProductService productService;

        public GetProductQueryHandler(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task<ResponseResult<ProductVM>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await productService.GetProductByIdAsync(request.Id);
        }
    }
}
