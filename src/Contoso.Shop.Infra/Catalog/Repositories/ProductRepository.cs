using Contoso.Shop.Infra.Shared;
using Contoso.Shop.Model.Catalog;
using Contoso.Shop.Model.Catalog.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contoso.Shop.Infra.Catalog.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext dataContext;

        public ProductRepository(ShopDbContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await dataContext.Products.ToListAsync();
        }
    }
}
