namespace Homework12;

public class Terminal
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