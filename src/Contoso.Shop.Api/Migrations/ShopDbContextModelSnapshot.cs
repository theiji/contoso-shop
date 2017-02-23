using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Contoso.Shop.Infra.Shared;

namespace Contoso.Shop.Api.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contoso.Shop.Model.Catalog.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departaments");
                });

            modelBuilder.Entity("Contoso.Shop.Model.Catalog.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<int>("DepartamentId");

                    b.Property<string>("Description");

                    b.Property<DateTimeOffset?>("ModifiedAt");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Contoso.Shop.Model.Catalog.Product", b =>
                {
                    b.HasOne("Contoso.Shop.Model.Catalog.Departament", "Departament")
                        .WithMany()
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
