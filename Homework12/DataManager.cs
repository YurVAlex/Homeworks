namespace Homework12;

public class DataManager
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