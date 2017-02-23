using Contoso.Shop.Model.Catalog.Commands;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Shop.Api.Catalog.Dtos
{
    public class CreateProductDto : ICreateProduct
    {
        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        [MinLength(3), MaxLength(50)]
        public string Description { get; set; }

        [Required, Range(0, 1000000)]
        public decimal? Price { get; set; }

        [Required]
        public int? DepartamentId { get; set; }
    }
}
