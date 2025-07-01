using Specification.Entity;
using Specification.Speci;

public class ActiveUserSpecification : CompositeSpecification<User>
{
    public override bool IsSatisfiedBy(User entity)
    {
        return entity.IsActive;
    }
}