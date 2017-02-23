namespace Contoso.Shop.Model.Catalog.Commands
{
    public interface ICreateProduct
    {
        string Name { get; }

        string Description { get; }

        decimal? Price { get; }

        int? DepartamentId { get; }
    }
}
