using Contoso.Shop.Model.Catalog.Commands;
using Contoso.Shop.Model.Catalog.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contoso.Shop.Model.Catalog.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> Create(ICreateProduct command);
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

        public async Task<Product> Create(ICreateProduct command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            var product = new Product()
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price.GetValueOrDefault(),
                DepartamentId = command.DepartamentId.GetValueOrDefault(),
                CreatedAt = DateTimeOffset.Now
            };

            await productRepository.Insert(product);

            return product;
        }
    }
}
