using Contoso.Shop.Model.Catalog.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contoso.Shop.Model.Catalog.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            return productRepository.GetAll();
        }
    }
}
