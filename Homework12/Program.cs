namespace Homework12;

public class Program
{
    static void Main(string[] args)
    {
        Storage.AddUser(new User("Karabas Barabas", 68, "Bad@mail.bas"));
        Storage.AddUser(new User("Yury Vouchak", 41, "Yura-va@tut.by"));
        Storage.AddUser(new User("Tolik Alcoholic", 51, "Toljamba@mail.com"));

        DataManager.Run();
    }
}