namespace Homework13;

public class Program
{
    static void Main(string[] args)
    {
        var timesProvider = new NewsProvider("Times");
        var alJazeeraProvider = new NewsProvider("Al Jazeera");
        var comixZoneProvider = new NewsProvider("Comix Zone");

        var lola = new Client("Lola", timesProvider, Category.Humor, Category.Sports);
        var alex = new Client("Alex", alJazeeraProvider);
        var anatoly = new Client("Anatoly", comixZoneProvider, Category.Humor);

        alex.AddSubscriptions(timesProvider);
        anatoly.AddSubscriptions(timesProvider, Category.Politics);

        // This call will correctly not create a duplicate subscription due to the check in AddSubscriptions
        lola.AddSubscriptions(timesProvider, Category.Sports);

        Console.WriteLine("--- Notifying Times Provider ---");
        timesProvider.Notify(Category.Sports, "Breaking news! New record in sprint!");
        timesProvider.Notify(Category.Politics, "Reality: Barabbas become next president of Barbados!");

        Console.WriteLine("\n--- Notifying Al Jazeera Provider ---");
        alJazeeraProvider.Notify(Category.Sports, "Breaking! New record in sprint!");
        alJazeeraProvider.Notify(Category.Politics, "Awesome! Barabbas become next president of Barbados!");

        Console.WriteLine("\n--- Notifying Times Provider (Technology) ---");
        timesProvider.Notify(Category.Technology, "Technological breakthrough: release of the new version of .NET!");

        Console.WriteLine("\n--- Notifying Comix Zone Provider ---");
        comixZoneProvider.Notify(Category.Humor, "A programmer walks into a bar...");
    }
}
