using System.Text;

namespace Homework08;

public class Task2
{
    public static void Run()
    {
        do
        {
            Output.Print(Header.CombineTask);
            Output.Print(Prompt.UserInput);
            Output.Print(Prompt.EngageTest);
            Output.Print(Prompt.Exit);

        } while (InputProcessor.IsActive(Console.ReadLine(), TestCases.Combine, RemoveSpaces));
    }

    public static void RemoveSpaces(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Output.Print(Message.NoInput);
            return;
        }
        var combine = new StringBuilder();

        foreach (var symbol in input)
        {
            if (!char.IsWhiteSpace(symbol))
            {
                combine.Append(symbol);
            }
        }
        Output.Print(Message.ResultPromise);
        Output.Print(combine.ToString() + "\n");
    }
}