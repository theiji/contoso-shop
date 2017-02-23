using Contoso.Shop.Api.Catalog.Dtos;
using Contoso.Shop.Model.Catalog.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Contoso.Shop.Model.Catalog;
using System;

namespace Contoso.Shop.Api.Catalog
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await productService.GetAll();

            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Objeto não pode ser nulo");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = await productService.Create(dto);

            return Ok(MapToDto(product));
        }

        private ProductDto MapToDto(Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                DepartamentId = product.DepartamentId
            };
        }
    }
}
