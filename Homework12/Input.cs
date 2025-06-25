namespace Homework12;

public class Input
{
    private static string _inputName, _inputEmail;
    private static int _inputAge;

    public static void SaveNewValidUserData()
    {
        if (TryReadValidName() && TryReadValidAge() && TryReadValidEmail())
        {
            Storage.DirectSave(new User(_inputName, _inputAge, _inputEmail));
        }
        else
        {
            Output.Warning("Process aborted. New user's data not added.");
        }
    }

    public static bool TryReadValidName()
    {
        while (true)
        {
            Console.Clear();
            Output.Prompt("Enter user's name in specific string format:");
            Output.Prompt("To exit this section - enter \"exit\"\n");

            _inputName = Console.ReadLine();

            if (_inputName.ToLower() == "exit")
            {
                return false;
            }
            if (User.IsValidName(_inputName))
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
            Output.Prompt($"Enter user's age (integer from 0 to {User.MaxAge}):");
            Output.Prompt("To exit this section - enter \"exit\"\n");

            var input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
            {
                return false;
            }
            if (int.TryParse(input, out _inputAge) && User.IsValidAge(_inputAge))
            {
                return true;
            }
            
            Output.Warning($"Invalid input. Please enter a valid age (integer between 0 and {User.MaxAge}).");
            Output.PressAndClear();
        }
    }

    public static bool TryReadValidEmail()
    {
        while (true)
        {
            Console.Clear();
            Output.Prompt("Enter user's e-mail:");
            Output.Prompt("To exit this section - enter \"exit\"\n");

            _inputEmail = Console.ReadLine().Trim();

            if (_inputEmail.ToLower() == "exit")
            {
                return false;
            }
            if (User.IsValidEmail(_inputEmail))
            {
                return true;
            }

            Output.Warning("Invalid input. Please enter a valid e-mail address.");
            Output.PressAndClear();
        }
    }
}