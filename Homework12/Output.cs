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

    public static void ShowAllUsersData(string[] data)
    {
        if (!Storage.Exists())
        {
            Warning("The storage is missing or has not been initialized yet. Try adding some data first.");
            return;
        }

        if (data.Length == 0)
        {
            Warning("The storage is empty");
        }
        else
        {
            Header("All Users:");
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
}