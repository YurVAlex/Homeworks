namespace Homework13;

public class Program
{
    static void Main(string[] args)
    {
        var provider01 = new NewsProvider("Times");
        var provider02 = new NewsProvider("Al Jazeera");
        var provider03 = new NewsProvider("Comix Zone");

        var lola = new Client("Lola", provider01, Category.Humor, Category.Sports);
        var alex = new Client("Alex", provider02);
        var anatoly = new Client("Anatoly", provider03, Category.Humor);

        provider01.Notify(Category.Sports, "Breaking news! New record in sprint!");
        provider01.Notify(Category.Politics, "Reality: Barabbas become next president of Barbados!");
        provider02.Notify(Category.Sports, "Breaking! New record in sprint!");
        provider02.Notify(Category.Politics, "Awesome! Barabbas become next president of Barbados!");
        provider03.Notify(Category.Humor, "A programmer walks into a bar...");
    }
}
