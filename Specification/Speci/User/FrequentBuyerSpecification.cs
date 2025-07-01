using Specification.Entity;

public class FrequentBuyerSpecification : CompositeSpecification<User>
{
    private readonly int _minimumPurchases;

    public FrequentBuyerSpecification(int minimumPurchases)
    {
        _minimumPurchases = minimumPurchases;
    }

    public override bool IsSatisfiedBy(User user)
    {
        return user.PurchasesCount >= _minimumPurchases;
    }
}