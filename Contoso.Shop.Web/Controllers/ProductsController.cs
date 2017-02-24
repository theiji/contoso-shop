using Contoso.Shop.Model.Catalog.Services;
using Contoso.Shop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Contoso.Shop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await productService.GetAll();

            var vm = new ListProductsViewModel
            {
                Products = products
            };

            return View(vm);
        }
    }
}
