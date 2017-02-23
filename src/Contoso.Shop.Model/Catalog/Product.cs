using System;

namespace Contoso.Shop.Model.Catalog
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? ModifiedAt { get; set; }

        public int DepartamentId { get; set; }
        public Departament Departament { get; set; }
    }
}
