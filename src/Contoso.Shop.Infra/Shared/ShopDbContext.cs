using Contoso.Shop.Model.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Shop.Infra.Shared
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Departament> Departaments { get; set; }
    }
}
