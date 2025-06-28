namespace Homework12;

public class Menu
{
    public static bool IsActive { get; set; } = true;

    public static void Show()
    {
        Output.ShowHeader("Users data management system");
        Output.ShowPrompt("To show all users data enter \"show\"");
        Output.ShowPrompt("To add new user data - enter \"add\"");
        Output.ShowPrompt("To exit this task - enter \"exit\"");
        Output.ShowMessage("Please enter a chosen option:");
    }

    public static void ReadMenuCommand()
    {
        switch (Console.ReadLine().ToLower())
        {
            case "exit":
            {
                IsActive = false;
                break;
            }
            case "show":
            {
                Console.Clear();
                Output.ShowAllUsersData(Storage.LoadAllUsersData());
                Output.PressAndClear();
                break;
            }
            case "add":
            {
                var newUserData = Input.MakeNewValidUser();
                if (newUserData != null)
                {
                    Storage.DirectSave(newUserData);
                }
                Output.PressAndClear();
                break;
            }
            default:
            {
                Output.ShowWarning("Invalid input. Try again.");
                Output.PressAndClear();
                break;
            }
        }
    }
}