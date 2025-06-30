namespace Homework09;

public class Program
{
    static void Main(string[] args)
    {
        Task1.Run();

        GoToNext();

        Task2.Run();

        GoToNext();

        Task3.Run();
    }

    public static void GoToNext()
    {
        Console.WriteLine("\nTo move to the next task, press any key...");
        Console.ReadKey();
        Console.Clear();
    }
}
