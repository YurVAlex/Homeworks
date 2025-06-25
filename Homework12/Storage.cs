using System.Text.Json;

namespace Homework12;

public class Storage
{
    private static string _storagePath = "users.json";

    public static void Save(User user)
    {
        if (user.IsValid())
        {
            DirectSave(user);
        }
        else
        {
            Output.Error($"User ({user}) - have an invalid data format. Saving was interrupted.");
        }
    }

    public static void DirectSave(User user)
    {
        var json = JsonSerializer.Serialize(user) + "\n";

        File.AppendAllText(_storagePath, json);

        Output.Message($"User ({user}) - added to storage.");
    }

    public static void ShowAllUsers()
    {
        if (!File.Exists(_storagePath) || new FileInfo(_storagePath).Length == 0)
        {
            Output.Message("No users found in storage.");
            return;
        }

        Output.Header("All Users:");

        try
        {
            foreach (var line in File.ReadAllLines(_storagePath))
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
                    catch { } // to skip non-serializable (damaged) lines
                }
            }
        }
        catch (Exception ex)
        {
            Output.Error("Failed to read users: " + ex.Message);
        }
    }
}
