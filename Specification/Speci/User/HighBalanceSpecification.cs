using Specification.Entity;

public class HighBalanceSpecification : CompositeSpecification<User>
{
    private readonly decimal _minimumBalance;

    public HighBalanceSpecification(decimal minimumBalance)
    {
        _minimumBalance = minimumBalance;
    }

    public override bool IsSatisfiedBy(User user)
    {
        return user.Balance >= _minimumBalance;
    }
}