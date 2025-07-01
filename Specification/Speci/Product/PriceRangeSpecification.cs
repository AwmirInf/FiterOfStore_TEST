using Specification.Entity;
namespace Specification.Speci.Product;

public class PriceRangeSpecification : CompositeSpecification<Specification.Entity.Product>
{
    private readonly decimal _minPrice;
    private readonly decimal _maxPrice;

    public PriceRangeSpecification(decimal minPrice, decimal maxPrice)
    {
        _maxPrice = maxPrice;   
        _minPrice = minPrice;
    }
    public override bool IsSatisfiedBy(Specification.Entity.Product product)
    {
        return product.Price >= _minPrice && product.Price <= _maxPrice;
    }
}