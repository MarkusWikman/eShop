namespace eShop.Data.Entities;
public class Size : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Category>? Categories { get; set; }
    public List<Color>? Colors { get; set; }
}
