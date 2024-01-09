using eShop.Data.Entities;

namespace eShop;
public class Category : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product>? Products { get; set; }
    public List<Filter>? Filters { get; set; }
}
