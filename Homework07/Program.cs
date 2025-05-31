namespace Homework07;

public class Program
{
    static void Main(string[] args)
    {
        Task1();
    }

    public static void Task1()
    {
        while (true)
        {
            Output.Print(Header.PalindromeTask);
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
                    PressAndClear();
                    break;
                }
                default:
                {
                    Output.Print(IsPalindrome(userInput) ? Message.IsPalindrome :
                                                            Message.IsNotPalindrome);
                    PressAndClear();
                    break;
                }
            }
        }
    }

    public static void PressAndClear()
    {
        Output.Print(Prompt.PressKey);
        Console.ReadKey();
        Console.Clear();
    }

    public static bool IsPalindrome(string input)
    {
        var reversed = string.Empty;

        for (int k = input.Length - 1; k >= 0; k--)
        {
            if (char.IsLetter(input[k]))
            {
                reversed += input[k]; 
            }
            else
            {
                input = input.Remove(k, 1); 
            }
        }

       return input == reversed;
    }
}
