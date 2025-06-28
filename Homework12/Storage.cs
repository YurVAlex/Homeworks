using System.Text.Json;

namespace Homework12;

public static class Storage
{
    private static string _storagePath = "users.json";

    static Storage() // To initially create a storage
    {
        try
        {
            if (!File.Exists(_storagePath))
            {
                File.Create(_storagePath).Close();
            }
        }
        catch (Exception ex)
        {
            Output.ShowError($"Failed to create {_storagePath}: " + ex.Message);
        }
    }

    public static bool ExistsAndNotEmpty (out string message)
    {
        if(!File.Exists(_storagePath))
        {
            message = "The storage is missing or has not been initialized.";
            return false;
        }
        
        if (new FileInfo(_storagePath).Length == 0)
        {
            message = "The storage is empty.";
            return false;
        }

        message = "The storage exists and is not empty.";
        return true;
    }

    public static void Save(User user)
    {
        if (Validator.IsValid(user))
        {
            DirectSave(user);
        }
        else
        {
            Output.ShowError($"User ({user}) - incorrect data entered. Saving was interrupted.");
        }
    }

    public static void DirectSave(User user)
    {
        var json = JsonSerializer.Serialize(user) + "\n";

        File.AppendAllText(_storagePath, json);

        Output.ShowMessage($"User ({user}) - added to storage.");
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
            Output.ShowError("Failed to read users: " + ex.Message);
        }

        return data;
    }
}