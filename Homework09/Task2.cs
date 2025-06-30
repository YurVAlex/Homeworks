namespace Homework09;

public class Task2
{
    public static void Run()
    {
        var products = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            ["MacBook"] = 2525.25,
            ["iPad"] = 777.77,
            ["iPhone"] =  555.55
        };
        products["Apple Watch"] = 457.85;
        products["Apple Pencil Pro"] = 99.99;

        ProductsListPrinter.Print(products);

        Console.Write("\nEnter product name to search:\n");
        if (products.TryGetValue(Console.ReadLine().Trim(), out double price))
        {
            Console.WriteLine($"Price: ${price:F2}");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        Console.WriteLine("\nPrices increased by 10%:");
        foreach (var key in products.Keys)
        {
            products[key] *= 1.10;
        }
        ProductsListPrinter.Print(products);
    }
}