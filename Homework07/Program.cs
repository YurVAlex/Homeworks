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
                        for (int i = 0; i < userInput.Length; i++)
                        {
                            if (!char.IsLetter(userInput[i]))
                            {
                                userInput = userInput.Remove(i--, 1);
                            }
                        }

                        var isPalindrome = true;
                        for (int i = 0; i < userInput.Length / 2; i++)
                        {
                            if (userInput[i] != userInput[^(i + 1)])
                            {
                                isPalindrome = false;
                                break;
                            }
                        }

                        Output.Print(isPalindrome ? Message.IsPalindrome : 
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
}
