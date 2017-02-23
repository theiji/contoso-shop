using Contoso.Shop.Model.Catalog;
using Contoso.Shop.Model.Catalog.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contoso.Shop.Infra.Catalog.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public async Task<IEnumerable<Product>> GetAll()
        {
            return new[]
            {
                new Product { Id = 1, Name = "iPhone 7", Price = 2999.99M },
                new Product { Id = 2, Name = "Samsung S7", Price = 2699.99M }
            };
        }
    }
}
