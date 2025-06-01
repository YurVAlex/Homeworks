namespace Homework08;

public class Task1
{
    public static void Run()
    {
        while (true)
        {
            Output.Print(Header.PalindromeTask);
            Output.Print(Message.PalinromeWiki);
            Output.Print(Prompt.UserInput);
            Output.Print(Prompt.EngageTest);
            Output.Print(Prompt.Exit);

            var userInput = Console.ReadLine().ToLower();

            switch (userInput)
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
                    ShowResult(userInput);

                    Output.PressAndClear();
                    break;
                }
            }
        }
    }

    public static bool IsPalindrome(string input)
    {
        var reversed = string.Empty;

        for (int k = input.Length - 1; k >= 0; k--)
        {
            if (char.IsLetterOrDigit(input[k]))
            {
                reversed += input[k];
            }
            else
            {
                input = input.Remove(k, 1);
            }
        }
        return (input.Length > 0) && (input == reversed);
    }

    public static void EngageTest()
    {
        Console.Clear();
        Output.Print(Header.TestCase);

        foreach (var item in TestCases.Palindromes)
        {
            Output.Print(Message.ItemPromise);
            Console.WriteLine(item);

            if (string.IsNullOrEmpty(item))
            {
                Output.Print(Message.NoInput);
                continue;
            }

            ShowResult(item);
        }
        Output.PressAndClear();
    }

    public static void ShowResult(string input)
    {
        Output.Print(IsPalindrome(input.ToLower()) ? Message.IsPalindrome :
                                                     Message.IsNotPalindrome);
    }
}
