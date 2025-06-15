namespace Homework11;

public class Output
{
    public static void Finish()
    {
        Console.WriteLine("\n\nTo finish this task, press any key...");
        Console.ReadKey();
        Console.Clear();
    }

    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"\n{message}\n\n");
        Console.ResetColor();
    }

    public static void Warning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\n\n{message}");
        Console.ResetColor();
    }

    public static void Important(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"\n{message}\n\n");
        Console.ResetColor();
    }
}
