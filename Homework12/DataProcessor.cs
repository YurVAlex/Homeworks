using System.Text.RegularExpressions;
using System.Text.Json;

namespace Homework12;

public class DataProcessor
{
    private static string _validName;
    private static string _validEmail;
    private static int _validAge;

    public static void AddNewUserData()
    {
        if (TryReadValidUserName() && TryReadValidUserAge() && TryReadValidUserEmail())
        {
            AddUserToFile(new User(_validName, _validAge, _validEmail));
        }
        else
        {
            Output.Warning("Process aborted. New user's data not added.");
        }
    }

    public static bool TryReadValidUserName()
    {
        var regex = new Regex(@"^[A-Za-z\s'-]{2,}$");

        while (true)
        {
            Output.Prompt("Enter user's name in specific string format: ");
            Output.Prompt("To exit this section - enter \"exit\"");
            _validName = Console.ReadLine().ToLower();

            if (_validName == "exit")
            {
                return false;
            }

            if (regex.IsMatch(_validName))
            {
                return true;
            }

            Output.Warning("Invalid input. Please enter a valid name " +
                  "(at least 2 letters, only letters, spaces, apostrophes, or hyphens).");
        }
    }

    public static bool TryReadValidUserAge()
    {
        while (true)
        {
            Output.Prompt("Enter user's age (integer from 1 to 150): ");
            Output.Prompt("To exit this section - enter \"exit\"");
            var input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
            {
                return false;
            }

            if (int.TryParse(input, out _validAge) && _validAge >= 1 && _validAge <= 150)
            {
                return true;
            }

            Output.Warning("Invalid input. Please enter a valid age (integer between 1 and 150).");
        }
    }

    public static bool TryReadValidUserEmail()
    {
        var regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

        while (true)
        {
            Output.Prompt("Enter user's e-mail: ");
            Output.Prompt("To exit this section - enter \"exit\"");
            _validEmail = Console.ReadLine().Trim();

            if (_validEmail.ToLower() == "exit")
            {
                return false;
            }

            if (regex.IsMatch(_validEmail))
            {
                return true;
            }
            Output.Warning("Invalid input. Please enter a valid e-mail address.");
        }
    }

    public static void AddUserToFile(User user)
    {
        var json = JsonSerializer.Serialize(user);

        File.AppendAllText("Users.json", json);

        Output.Message($"User ({user}) - added to storage.");
    }




}