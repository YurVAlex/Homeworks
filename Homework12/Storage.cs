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
            Output.Error($"User ({user}) - incorrect data entered. Saving was interrupted.");
        }
    }

    public static void DirectSave(User user)
    {
        var json = JsonSerializer.Serialize(user) + "\n";

        File.AppendAllText(_storagePath, json);

        Output.Message($"User ({user}) - added to storage.");
    }

    public static bool Exists()
    {
        return File.Exists(_storagePath);
    }

    public static string[] LoadAllUsersData()
    {
        var data = Array.Empty<string>();

        try
        {
            data = File.ReadAllLines(_storagePath);
        }
        catch (Exception ex)
        {
            Output.Error("Failed to read users: " + ex.Message);
        }

        return data;
    }
}