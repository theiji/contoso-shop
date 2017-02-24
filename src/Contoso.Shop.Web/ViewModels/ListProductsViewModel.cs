using System.Collections.Generic;
using Contoso.Shop.Model.Catalog;

namespace Contoso.Shop.Web.ViewModels
{
    public class ListProductsViewModel
    {
        public ListProductsViewModel()
        {
            // Array.Empty<Product>
            Products = new List<Product>();
        }

        public IEnumerable<Product> Products { get; set; }
        public string Keywords { get; set; }
    }
}