namespace Homework12;

public class UsersDataManager
{
    public static void Run()
    {
        do
        {
            Menu.Show();
            Menu.ReadInput();

        } while (Menu.IsActive);
    }
}