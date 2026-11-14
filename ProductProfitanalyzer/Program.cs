try
{
    Console.WriteLine("Product name :");
    string ProductName = Console.ReadLine();
    if (ProductName == "")
    {
        while (ProductName == "")
        {
            Console.WriteLine("Error:Product name must not be empty");
            Console.WriteLine("Product name :");
            ProductName = Console.ReadLine();
            if (ProductName != "")
            {
                break;
            }
        }
    }
    Console.WriteLine("Purchase price :");
    double PurchasePrice = Convert.ToDouble(Console.ReadLine());
    if (PurchasePrice < 0)
    {
        Console.WriteLine("Error: must be grater than zero");
    }
    Console.WriteLine("Purchase price :");
    PurchasePrice = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Packaging cost :");
    double PackagingCost = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Shipping cost :");
    double ShippingCost = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Selling price :");
    double SellingPrice = Convert.ToDouble(Console.ReadLine());

    double FeeRate = PurchasePrice * 10 / 100;




    Console.WriteLine("---------------");
    Console.WriteLine("Product information received");
    Console.WriteLine($"Product name : {ProductName}");
    Console.WriteLine($"Purchase price : {PurchasePrice}");
    Console.WriteLine($"Packaging cost : {PackagingCost}");
    Console.WriteLine($"Shipping cost : : {ShippingCost}");
    Console.WriteLine($"Selling price : : {SellingPrice}");
    Console.WriteLine($"Fee rate is 10% of Purchase price : {FeeRate}");
    Console.WriteLine("---------------");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

