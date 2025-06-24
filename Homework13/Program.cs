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

        lola.AddSubscriptions(timesProvider, Category.Sports); // Check for unnecessary double subscription

        timesProvider.Notify(Category.Sports, "Breaking news! New record in sprint!");
        timesProvider.Notify(Category.Politics, "Reality: Barabbas become next president of Barbados!");
        
        alJazeeraProvider.Notify(Category.Sports, "Breaking! New record in sprint!");
        alJazeeraProvider.Notify(Category.Politics, "Awesome! Barabbas become next president of Barbados!");
        
        timesProvider.Notify(Category.Technology, "Technological breakthrough: release of the new version of .NET!");
        
        comixZoneProvider.Notify(Category.Humor, "A programmer walks into a bar...");
    }
}
