namespace Homework12;

public class Program
{
    static void Main(string[] args)
    {
        Storage.Save(new User("Karabas Barabas", 68, "Bad@mail.bas"));
        Storage.Save(new User("Yury Vouchak", 41, "Yura-va@tut.by"));
        Storage.Save(new User("Anatoly Detox", 51, "Toljamba@mail.com"));

        Storage.Save(new User("Broken~User~Name", 22, "test@mail.ru"));
        Storage.Save(new User("Broken Age", -7, "test@mail.ru"));
        Storage.Save(new User("Super Star", 151, "test@mail.ru"));
        Storage.Save(new User("Bad E-mail", 77, "test.bad"));

        Output.PressAndClear();

        Terminal.Run();
    }
}