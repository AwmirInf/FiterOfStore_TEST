namespace Specification.Speci.Product;

public class QuantitySpecification : CompositeSpecification<Entity.Product>
{
    public override bool IsSatisfiedBy(Specification.Entity.Product product)
    {
        return product.Quantity >= 1;
    }
}