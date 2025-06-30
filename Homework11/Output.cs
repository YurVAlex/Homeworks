namespace Homework11;

public class Output
{
    public static void Finish()
    {
        Console.WriteLine("To finish this task, press any key...");
        Console.ReadKey();
        Console.Clear();
    }

    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"\n{message}\n\n");
        Console.ResetColor();
    }
}