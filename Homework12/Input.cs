namespace Homework12;

public class Input
{
    private static string _validName, _validEmail;
    private static int _validAge;

    public static User? MakeNewValidUser()
    {
        return IsValidUserDataEntered() ? new User(_validName, _validAge, _validEmail) : null;
    }

    private static bool IsValidUserDataEntered()
    {
        if (TryReadValidName() && TryReadValidAge() && TryReadValidEmail())
        {
            return true;
        }
        else
        {
            Output.ShowWarning("Process aborted. New user's data not added.");
            return false;
        }
    }

    private static bool TryReadValidName()
    {
        while (true)
        {
            Console.Clear();
            Output.ShowPrompt("Enter user's name in specific string format:");
            Output.ShowPrompt("To exit this section - enter \"exit\"\n");

            var input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                return false;
            }
            if (User.IsValidName(input))
            {
                _validName = input;
                return true;
            }

            Output.ShowWarning("Invalid input. Please enter a valid name " +
                  "(at least 2 letters, only letters, spaces, apostrophes, or hyphens).");
            Output.PressAndClear(); 
        }
    }

    private static bool TryReadValidAge()
    {
        while (true)
        {
            Console.Clear();
            Output.ShowPrompt($"Enter user's age (integer from 0 to {User.MaxAge}):");
            Output.ShowPrompt("To exit this section - enter \"exit\"\n");

            var input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
            {
                return false;
            }
            if (int.TryParse(input, out var number) && User.IsValidAge(number))
            {
                _validAge = number;
                return true;
            }
            
            Output.ShowWarning($"Invalid input. Please enter a valid age (integer between 0 and {User.MaxAge}).");
            Output.PressAndClear();
        }
    }

    private static bool TryReadValidEmail()
    {
        while (true)
        {
            Console.Clear();
            Output.ShowPrompt("Enter user's e-mail:");
            Output.ShowPrompt("To exit this section - enter \"exit\"\n");

            var input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
            {
                return false;
            }
            if (User.IsValidEmail(input))
            {
                _validEmail = input;
                return true;
            }

            Output.ShowWarning("Invalid input. Please enter a valid e-mail address.");
            Output.PressAndClear();
        }
    }
}