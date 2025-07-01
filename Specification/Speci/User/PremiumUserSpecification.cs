using Specification.Entity;
using Specification.Speci;

public class PremiumUserSpecification : CompositeSpecification<User>
{
    public override  bool IsSatisfiedBy(User entity)
    {
        return entity.IsPremium;
    }
}