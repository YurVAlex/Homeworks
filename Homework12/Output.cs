using System.Text.Json;

namespace Homework12;

public class Output
{
    public static void PressAndClear()
    {
        Console.WriteLine("\nTo continue, press any key...");
        Console.ReadKey();
        Console.Clear();
    }

    public static void ShowHeader(string message)
    {
        Console.Write($"---=== {message.ToUpper()} ===---\n");
    }

    public static void ShowPrompt(string message)
    {
        Console.Write($"\n==> {message}\n");
    }

    public static void ShowWarning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\n{message}\n\n");
        Console.ResetColor();
    }

    public static void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"\n{message}\n\n");
        Console.ResetColor();
    }

    public static void ShowMessage(string message)
    {
        Console.Write($"\n{message}\n\n");
    }

    public static void ShowAllUsersData(IEnumerable<string> data)
    {
        ShowHeader("All Users");

        foreach (var line in data)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                try
                {
                    var user = JsonSerializer.Deserialize<User>(line.Trim());
                    if (user != null)
                    {
                        Console.WriteLine($"{user}");
                    }
                }
                catch { } // to ignore non-serializable (damaged) lines
            }
        }
    }
}