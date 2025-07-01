namespace Specification.Entity;

public class User
{
    public bool IsActive { get; set; }
    public bool IsPremium { get; set; }
    public decimal Balance { get; set; }
    public int PurchasesCount { get; set; }
}
