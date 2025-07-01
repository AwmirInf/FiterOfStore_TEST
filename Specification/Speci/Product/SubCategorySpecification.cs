using Specification.Entity;

public class SubCategorySpecification : CompositeSpecification<Product>
{
    private readonly int _subCategoryId;

    public SubCategorySpecification(int subCategoryId)
    {
        _subCategoryId = subCategoryId;
    }

    public override bool IsSatisfiedBy(Product product)
    {
        return product.SubCategory.Id == _subCategoryId;
    }
}