using Contoso.Shop.Model.Catalog.Services;
using Contoso.Shop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        [HttpPost]
        public async Task<IActionResult> Index(ListProductsViewModel vm)
        {
            var products = await productService.GetAll();

            vm = vm ?? new ListProductsViewModel();

            if (!string.IsNullOrWhiteSpace(vm.Keywords))
            {
                products = products.
                    Where(x => x.Name.Contains(vm.Keywords) ||
                               x.Description.Contains(vm.Keywords));
            }

            vm.Products = products;

            return View(vm);
        }
    }
}
