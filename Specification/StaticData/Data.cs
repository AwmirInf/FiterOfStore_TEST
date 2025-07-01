namespace Specification.StaticData;
using Specification.Entity;
public static class Data
{
    public static List<Product> GetProducts()
    {
        var allProducts = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop Gaming A",
                SubCategory = new SubCategory
                {
                    Id = 1,
                    Name = "Gaming Laptop",
                    Category = new Category { Id = 1, Name = "Laptops" }
                },
                Price = 3500,
                Quantity = 0,
                Features = new List<ProductFeature>
                {
                    new ProductFeature { Key = "RAM", Value = "16GB" },
                    new ProductFeature { Key = "RAM", Value = "8GB" },
                    new ProductFeature { Key = "GPU", Value = "RTX 3060" },
                    new ProductFeature { Key = "Color", Value = "Black" },
                    new ProductFeature { Key = "CPU", Value = "i7" }
                }
            },
            new Product
            {
                Id = 2,
                Name = "Laptop Business B",
                SubCategory = new SubCategory
                {
                    Id = 2,
                    Name = "Business Laptop",
                    Category = new Category { Id = 1, Name = "Laptops" }
                },
                Price = 2500,
                Quantity = 2,
                Features = new List<ProductFeature>
                {
                    new ProductFeature { Key = "RAM", Value = "8GB" },
                    new ProductFeature { Key = "GPU", Value = "Integrated" },
                    new ProductFeature { Key = "Color", Value = "Silver" },
                    new ProductFeature { Key = "CPU", Value = "i5" }
                }
            },
            new Product
            {
                Id = 3,
                Name = "Laptop Gaming C",
                SubCategory = new SubCategory
                {
                    Id = 1,
                    Name = "Gaming Laptop",
                    Category = new Category { Id = 1, Name = "Laptops" }
                },
                Quantity = 1,
                Price = 5500,
                Features = new List<ProductFeature>
                {
                    new ProductFeature { Key = "RAM", Value = "32GB" },
                    new ProductFeature { Key = "GPU", Value = "RTX 4090" },
                    new ProductFeature { Key = "Color", Value = "Black" },
                    new ProductFeature { Key = "CPU", Value = "i9" }
                }
            },
            new Product
            {
                Id = 4,
                Name = "Laptop Light D",
                SubCategory = new SubCategory
                {
                    Id = 3,
                    Name = "Lightweight Laptop",
                    Category = new Category { Id = 1, Name = "Laptops" }
                },
                Quantity = 0,
                Price = 1500,
                Features = new List<ProductFeature>
                {
                    new ProductFeature { Key = "RAM", Value = "16GB" },
                    new ProductFeature { Key = "GPU", Value = "Integrated" },
                    new ProductFeature { Key = "Color", Value = "White" },
                    new ProductFeature { Key = "CPU", Value = "i5" }
                }
            }
        };
        return allProducts;
    }
}