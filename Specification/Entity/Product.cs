namespace Specification.Entity;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public SubCategory SubCategory { get; set; }
    public List<ProductFeature> Features { get; set; } = new List<ProductFeature>();
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
    public int Quantity { get; set; }   
}