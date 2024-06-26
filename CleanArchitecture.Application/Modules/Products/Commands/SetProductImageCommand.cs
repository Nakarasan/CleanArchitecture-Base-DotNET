using CleanArchitecture.Application.Modules.Products.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Shared.Common.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Modules.Products.Commands
{
    public class SetProductImageCommand : IRequest<ResponseResult<bool>>
    {
        public int Id { get; set; }
        public IFormFile image { get; set; }
    }

    public class SetProductImageCommandHandler : IRequestHandler<SetProductImageCommand, ResponseResult<bool>>
    {
        private readonly IProductService productService;

        public SetProductImageCommandHandler(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task<ResponseResult<bool>> Handle(SetProductImageCommand request, CancellationToken cancellationToken)
        {
            return await productService.SetProductImageAsync(request.Id, request.image);
        }
    }

}
