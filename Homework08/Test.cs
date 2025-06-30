namespace Homework08;

public static class Test
{
    public static void Run(List<string> items, Action<string> process)
    {
        Console.Clear();
        Output.Print(Header.TestCase);

        foreach (var item in items)
        {
            Output.Print(Message.ItemPromise);
            Output.Print(item);

            process(item);
        }
        Output.PressAndClear();
    }
}
