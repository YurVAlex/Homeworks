namespace Homework12;

public class Output
{
    public static void PressAndClear()
    {
        Console.WriteLine("\nTo continue, press any key...");
        Console.ReadKey();
        Console.Clear();
    }

    public static void Header(string message)
    {
        Console.Write($"---=== {message.ToUpper()} ===---\n");
    }

    public static void Prompt(string message)
    {
        Console.Write($"\n==> {message}\n");
    }

    public static void Warning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\n{message}\n\n");
        Console.ResetColor();
    }

    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"\n{message}\n\n");
        Console.ResetColor();
    }

    public static void Message(string message)
    {
        Console.Write($"\n{message}\n\n");
    }
}