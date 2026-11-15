Console.WriteLine("Product Profit Analyzer");
Console.WriteLine("-----------------------");

string productName = "";

while (productName.Trim() == "" || productName.Length > 50)
{
    Console.Write("Product name: ");
    productName = Console.ReadLine() ?? "";

    if (productName.Trim() == "" || productName.Length > 50)
    {
        Console.WriteLine("Please enter a valid product name.");
    }
}

decimal purchasePrice = 0;

while (purchasePrice <= 0)
{
    Console.Write("Purchase price: ");

    try
    {
        purchasePrice = Convert.ToDecimal(Console.ReadLine());

        if (purchasePrice <= 0 || purchasePrice > 1000000000)
        {
            Console.WriteLine("Enter a valid price.");
            purchasePrice = 0;
        }
    }
    catch
    {
        Console.WriteLine("Please enter a number.");
    }
}

decimal packagingCost = -1;

while (packagingCost < 0)
{
    Console.Write("Packaging cost: ");

    try
    {
        packagingCost = Convert.ToDecimal(Console.ReadLine());

        if (packagingCost < 0 || packagingCost > 1000000000)
        {
            Console.WriteLine("Cost cannot be negative or too large.");
            packagingCost = -1;
        }
    }
    catch
    {
        Console.WriteLine("Please enter a number.");
    }
}

decimal shippingCost = -1;

while (shippingCost < 0)
{
    Console.Write("Shipping cost: ");

    try
    {
        shippingCost = Convert.ToDecimal(Console.ReadLine());

        if (shippingCost < 0 || shippingCost > 1000000000)
        {
            Console.WriteLine("Enter a valid shipping cost.");
            shippingCost = -1;
        }
    }
    catch
    {
        Console.WriteLine("Please enter a number.");
    }
}

decimal sellingPrice = 0;

while (sellingPrice <= 0)
{
    Console.Write("Selling price: ");

    try
    {
        sellingPrice = Convert.ToDecimal(Console.ReadLine());

        if (sellingPrice <= 0 || sellingPrice > 1000000000)
        {
            Console.WriteLine("Enter a valid selling price.");
            sellingPrice = 0;
        }
    }
    catch
    {
        Console.WriteLine("Please enter a number.");
    }
}

decimal feeRate = -1;

while (feeRate < 0)
{
    Console.Write("Platform fee (%): ");

    try
    {
        feeRate = Convert.ToDecimal(Console.ReadLine());

        if (feeRate < 0 || feeRate > 100)
        {
            Console.WriteLine("Fee must be between 0 and 100.");
            feeRate = -1;
        }
    }
    catch
    {
        Console.WriteLine("Please enter a number.");
    }
}

// Calculations

decimal platformFee = sellingPrice * feeRate / 100;
decimal totalCost = purchasePrice + packagingCost + shippingCost + platformFee;
decimal netProfit = sellingPrice - totalCost;
decimal profitMargin = netProfit / sellingPrice * 100;

// Report

Console.WriteLine();
Console.WriteLine("----- Product Report -----");

Console.WriteLine("Product: " + productName);
Console.WriteLine("Purchase price: " + purchasePrice);
Console.WriteLine("Packaging cost: " + packagingCost);
Console.WriteLine("Shipping cost: " + shippingCost);
Console.WriteLine("Selling price: " + sellingPrice);
Console.WriteLine("Platform fee: " + platformFee);

Console.WriteLine();
Console.WriteLine("Total cost: " + totalCost);
Console.WriteLine("Net profit: " + netProfit);
Console.WriteLine("Profit margin: " + profitMargin.ToString("0.00") + "%");

if (netProfit > 0)
{
    Console.WriteLine("Status: Profitable");
}
else if (netProfit < 0)
{
    Console.WriteLine("Status: Loss");
}
else
{
    Console.WriteLine("Status: Break-even");
}

Console.WriteLine("--------------------------");
