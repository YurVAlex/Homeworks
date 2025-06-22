using System.Text.RegularExpressions;

namespace Homework12;

public class Input
{
    private static string _validName;
    private static string _validEmail;
    private static int _validAge;

    public static void AddNewUserData()
    {
        if (TryReadValidName() && TryReadValidAge() && TryReadValidEmail())
        {
            Storage.AddUser(new User(_validName, _validAge, _validEmail));
        }
        else
        {
            Output.Warning("Process aborted. New user's data not added.");
        }
    }

    public static bool TryReadValidName()
    {
        var regex = new Regex(@"^[A-Za-z\s'-]{2,}$");

        while (true)
        {
            Console.Clear();
            Output.Prompt("Enter user's name in specific string format: ");
            Output.Prompt("To exit this section - enter \"exit\"\n");
            _validName = Console.ReadLine();

            if (_validName.ToLower() == "exit")
            {
                return false;
            }
           
            if (regex.IsMatch(_validName))
            {
                return true;
            }

            Output.Warning("Invalid input. Please enter a valid name " +
                  "(at least 2 letters, only letters, spaces, apostrophes, or hyphens).");
            Output.PressAndClear(); 
        }
    }

    public static bool TryReadValidAge()
    {
        while (true)
        {
            Console.Clear();
            Output.Prompt("Enter user's age (integer from 0 to 150): ");
            Output.Prompt("To exit this section - enter \"exit\"\n");
            var input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
            {
                return false;
            }
           
            if (int.TryParse(input, out _validAge) && _validAge >= 0 && _validAge <= 150)
            {
                return true;
            }
            
            Output.Warning("Invalid input. Please enter a valid age (integer between 0 and 150).");
            Output.PressAndClear();
        }
    }

    public static bool TryReadValidEmail()
    {
        var regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

        while (true)
        {
            Console.Clear();
            Output.Prompt("Enter user's e-mail: ");
            Output.Prompt("To exit this section - enter \"exit\"\n");
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
            Output.PressAndClear();
        }
    }
}