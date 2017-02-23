using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contoso.Shop.Model.Catalog.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
