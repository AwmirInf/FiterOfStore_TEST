

using Specification.Entity;

public class FeatureSpecification : CompositeSpecification<Product>
{
    private readonly string _key;
    private readonly string _value;

    public FeatureSpecification(string key, string value)
    {
        _key = key;
        _value = value;
    }

    public override bool IsSatisfiedBy(Product product)
    {
        return product.Features.Any(f => 
            f.Key.Equals(_key, StringComparison.OrdinalIgnoreCase) 
            && f.Value.Equals(_value, StringComparison.OrdinalIgnoreCase));
    }
}