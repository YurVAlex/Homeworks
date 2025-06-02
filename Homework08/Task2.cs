using System.Text;

namespace Homework08;

public class Task2
{
    public static void Run()
    {
        while (true)
        {
            Output.Print(Header.CombineTask);
            Output.Print(Prompt.UserInput);
            Output.Print(Prompt.EngageTest);
            Output.Print(Prompt.Exit);

            var userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "exit":
                {
                    Console.Clear();
                    return;
                }
                case "":
                {
                    Output.Print(Message.NoInput);
                    Output.PressAndClear();
                    break;
                }
                case "run":
                {
                    EngageTest();
                    break;
                }
                default:
                {
                    Output.Print(Message.ResultPromise);
                    Output.Print(RemoveSpaces(userInput) + "\n");

                    Output.PressAndClear();
                    break;
                }
            }
        }
    }

    public static string RemoveSpaces(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        var combine = new StringBuilder();

        foreach (var sumbol in input)
        {
            if (!char.IsWhiteSpace(sumbol))
            {
                combine.Append(sumbol);
            }
        }
        return combine.ToString();
    }

    public static void EngageTest()
    {
        Console.Clear();
        Output.Print(Header.TestCase);

        foreach (var item in TestCases.Combine)
        {
            Output.Print(Message.ItemPromise);
            Output.Print(item);

            if (string.IsNullOrEmpty(item))
            {
                Output.Print(Message.NoInput);
                continue;
            }

            Output.Print(Message.ResultPromise);
            Output.Print(RemoveSpaces(item) + "\n");
        }
        Output.PressAndClear();
    }
}