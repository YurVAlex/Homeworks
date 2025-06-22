using System.Text.Json;

namespace Homework12;

public class Storage
{
    private static string _storage = "Users.json";

    public static void AddUser(User user)
    {
        var json = JsonSerializer.Serialize(user) + "\n";

        File.AppendAllText(_storage, json);

        Output.Message($"User ({user}) - added to storage.");
    }

    public static void ShowAllUsers()
    {
        if (!File.Exists(_storage) || new FileInfo(_storage).Length == 0)
        {
            Output.Message("No users found in storage.");
            return;
        }

        Output.Header("All Users:");

        try
        {
            foreach (var line in File.ReadAllLines(_storage))
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
                    catch { }
                }
            }
        }
        catch (Exception ex)
        {
            Output.Error("Failed to read users: " + ex.Message);
        }
    }
}
