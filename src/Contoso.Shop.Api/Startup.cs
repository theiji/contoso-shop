using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Contoso.Shop.Model.Catalog.Services;
using Contoso.Shop.Model.Catalog.Repositories;
using Contoso.Shop.Infra.Catalog.Repositories;
using Contoso.Shop.Infra.Shared;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Shop.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopDbContext>(options =>
            {
                options.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=contoso-shop;" +
                    "Integrated Security=True", b => b.MigrationsAssembly("Contoso.Shop.Api"));
            });

            services.AddMvc();

            services.AddCors();

            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IProductRepository, ProductRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x.AllowAnyHeader().
                               AllowAnyMethod().
                               AllowAnyOrigin().
                               AllowCredentials());

            app.UseMvc();
        }
    }
}
