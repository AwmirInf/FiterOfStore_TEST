using Specification.Entity;
using Specification.Speci;
using Specification.Speci.Product;
using Specification.StaticData;

class Program
{
    public static void Main()
    {
        var filterReq = new List<FilterItem>()
        {
            new FilterItem() { Key = "RAM", Value = "16GB" },
            new FilterItem() { Key = "RAM", Value = "8GB" },
        };


        var selectFeaturs = filterReq.Select(f => (f.Key, f.Value)).ToList();

        var grouped = selectFeaturs
            .GroupBy(f => f.Key)
            .ToList();

        ISpecification<Product>? finalSpec = null;


        foreach (var group in grouped)
        {
            ISpecification<Product> groupSpec = null;

            foreach (var value in group)
            {
                var spec = new ExpressionSpecification<Product>(p =>
                    p.Features.Any(feat => feat.Key == group.Key && feat.Value == value.Value)
                );

                if (grouped is null)
                {
                    groupSpec = spec;
                }
                else
                {
                    groupSpec.Or(spec);
                }
                // groupSpec = groupSpec == null ? spec : groupSpec.Or(spec); 
            }

            finalSpec = finalSpec == null ? groupSpec : finalSpec.And(groupSpec);
        }


        var allProducts = Data.GetProducts();

        finalSpec ??= new ExpressionSpecification<Product>(p => true);
        var filteredProduct = allProducts
            .Where(p => finalSpec.IsSatisfiedBy(p))
            .ToList();
        foreach (var item in filteredProduct)
        {
            Console.WriteLine(item.Name);
        }

        #region TestProduct

        var ramSpec = new FeatureSpecification("RAM", "16GB");
        var gpuSpec = new FeatureSpecification("GPU", "RTX 3060");
        var colorSpec = new FeatureSpecification("Color", "Black");
        var priceSpec = new PriceRangeSpecification(1000, 5000);
        // var quantitySpec = new QuantitySpecification();
        var quantitySpec = new ExpressionSpecification<Product>(p => p.Quantity >= 1);
        var combinedSpec = ramSpec.Or(gpuSpec).Or(colorSpec).Or(ramSpec).And(priceSpec).And(quantitySpec);

        var filteredProducts = allProducts
            .Where(p => combinedSpec.IsSatisfiedBy(p))
            .ToList();

        foreach (var product in filteredProducts)
        {
            Console.WriteLine(product.Name);
        }

        #endregion


        #region Test3

        // var user = new User
        // {
        //     IsActive = true,
        //     IsPremium = true,
        //     Balance = 200000,
        //     PurchasesCount = 3
        // };
        //
        // //condition
        //
        // //var active = new ActiveUserSpecification();
        // var active = new ExpressionSpecification<User>(u=>u.IsActive);
        // var premium = new ExpressionSpecification<User>(u => u.IsPremium);
        // var highbalance = new ExpressionSpecification<User>(u=>u.Balance>=100000);
        // var purchasesCount = new ExpressionSpecification<User>(u=>u.PurchasesCount>=5);
        //
        // //composite of conditions 
        // var compisite = active.And(premium.And(highbalance.Or(purchasesCount)));
        // Console.WriteLine(compisite.IsSatisfiedBy(user));

        #endregion


        #region Test2

        // var user1 = new User
        // {
        //     IsActive = true,
        //     IsPremium = true,
        //     Balance = 150000,
        //     PurchasesCount = 10
        // };
        // var user2 = new User
        // {
        //     IsActive = false,
        //     IsPremium = true,
        //     Balance = 120000,
        //     PurchasesCount = 10
        // };
        // var user3 = new User
        // {
        //     IsActive = true,
        //     IsPremium = true,
        //     Balance = 100000,
        //     PurchasesCount = 6
        // };
        // List<User> users = new List<User>();
        // users.Add(user1);
        // users.Add(user2);
        // users.Add(user3);
        //
        // //condition
        // var activeUser = new ActiveUserSpecification();
        // var premiumUser = new PremiumUserSpecification();
        // var highBalance = new HighBalanceSpecification(100000);
        //
        // //composite of condition
        // var activeAndPremiumAndBalance = activeUser.And(premiumUser).And(highBalance);
        // var activeOrPremiumAndBalance = activeAndPremiumAndBalance.Or(premiumUser).And(highBalance);
        //
        // int i = 1;
        // foreach (var user in users)
        // {
        //     Console.WriteLine($"{i}: "+activeAndPremiumAndBalance.IsSatisfiedBy(user));
        //     if (activeAndPremiumAndBalance.IsSatisfiedBy(user))
        //     {
        //         Console.WriteLine($"================{i}===============");
        //     }
        //     i++;
        // }

        #endregion

        // var user1 = new User { IsActive = true, IsPremium = true };
        // var user2 = new User { IsActive = true, IsPremium = false };
        // var user3 = new User { IsActive = false, IsPremium = false };
        //
        // var activeSpec = new ActiveUserSpecification();
        // var premiumSpec = new PremiumUserSpecification();
        //
        // // ترکیب شرط: کاربر فعال و پرمیوم
        // var activeAndPremium = activeSpec.And(premiumSpec);
        //
        // // شرط: کاربر فعال یا پرمیوم
        // var activeOrPremium = activeSpec.Or(premiumSpec);
        //
        // // شرط: کاربر پرمیوم نباشد
        // var notPremium = premiumSpec.Not();
        //
        // // تست
        // Console.WriteLine($"User1 Active & Premium: {activeAndPremium.IsSatisfiedBy(user1)}"); // True
        // Console.WriteLine($"User2 Active & Premium: {activeAndPremium.IsSatisfiedBy(user2)}"); // False
        // Console.WriteLine($"User2 Active OR Premium: {activeOrPremium.IsSatisfiedBy(user2)}"); // True
        // Console.WriteLine($"User3 Not Premium: {notPremium.IsSatisfiedBy(user3)}"); // True
    }
}