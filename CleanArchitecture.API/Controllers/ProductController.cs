using CleanArchitecture.API.Contracts.V1;
using CleanArchitecture.Application.Modules.Products.Commands;
using CleanArchitecture.Application.Modules.Products.Models.Response;
using CleanArchitecture.Application.Modules.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Common.Helper.Models;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ApiControllerBase
    {

        [HttpGet(ApiRoutes.Product.GetAllProducts)]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var products = await Mediator.Send(new GetAllProductQuery());
            return Ok(products);
        }


        [HttpGet(ApiRoutes.Product.GetProductById)]
        public async Task<ResponseResult<ProductVM>> GetProductByIdAsync(int id)
        {
            return await Mediator.Send(new GetProductQuery() { Id = id });
        }


        [HttpPost(ApiRoutes.Product.CreateProduct)]
        public async Task<ResponseResult<int>> CreateProductAsync(CreateProductCommand command)
        {
            return await Mediator.Send(command);
        }


        [HttpPost(ApiRoutes.Product.UpdateProduct)]
        public async Task<ResponseResult<bool>> UpdateProductAsync(UpdateProductCommand command)
        {
            return await Mediator.Send(command);
        }

       /* [HttpPost("Set Product Image")]
        public async Task<ResponseResult<bool>> SetAvatarAsync(int id, IFormFile image)
        {
            return await Mediator.Send(new SetProductImageCommand() { Id = id, image = image });
        }*/
    }
}
