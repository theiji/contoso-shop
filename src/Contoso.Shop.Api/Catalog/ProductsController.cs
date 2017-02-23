using Contoso.Shop.Model.Catalog.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Contoso.Shop.Api.Catalog
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Get()
        {
            var products = await productService.GetAll();

            return Ok(products);
        }
    }
}
