using System.Collections.Generic;
using System.Threading.Tasks;
using Contoso.Shop.Model.Catalog.Commands;

namespace Contoso.Shop.Model.Catalog.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task Insert(Product product);
    }
}
