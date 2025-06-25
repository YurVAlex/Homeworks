namespace Homework12;

public class Program
{
    static void Main(string[] args)
    {
        Storage.Save(new User("Karabas Barabas", 68, "Bad@mail.bas"));
        Storage.Save(new User("Yury Vouchak", 41, "Yura-va@tut.by"));
        Storage.Save(new User("Anatoly Detox", 51, "Toljamba@mail.com"));

        Output.PressAndClear();

        Terminal.Run();
    }
}