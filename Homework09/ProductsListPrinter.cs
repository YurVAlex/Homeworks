namespace Homework09;

public class ProductsListPrinter
{
    public static void Print(Dictionary<string, double> products)
    {
        if (products == null || products.Count == 0)
        {
            Console.WriteLine("No products to display.");
            return;
        }

        Console.WriteLine("Product list:\n");
        Console.WriteLine("{0,-20} {1,10}", "Product", "Price");
        Console.WriteLine(new string('-', 32));
        foreach (var product in products)
        {
            Console.WriteLine("{0,-20} ${1,8:F2}", product.Key, product.Value);
        }
    }
}
