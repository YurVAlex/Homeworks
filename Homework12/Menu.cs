namespace Homework12;

public class Menu
{
    public static bool IsActive { get; set; } = true;

    public static void Show()
    {
        Output.Header("Users data management system");
        Output.Prompt("To show all users data enter \"show\"");
        Output.Prompt("To add new user data - enter \"add\"");
        Output.Prompt("To exit this task - enter \"exit\"");
        Output.Message("Please enter a chosen option:");
    }

    public static void ReadInput()
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
                Output.Warning("Invalid input. Try again.");
                Output.PressAndClear();
                break;
            }
        }
    }
}