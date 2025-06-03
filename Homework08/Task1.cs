namespace Homework08;

public class Task1
{
    public static void Run()
    {
        do
        {
            Output.Print(Header.PalindromeTask);
            Output.Print(Message.PalinromeWiki);
            Output.Print(Prompt.UserInput);
            Output.Print(Prompt.EngageTest);
            Output.Print(Prompt.Exit);

        } while (InputProcessor.IsActive(Console.ReadLine(), TestCases.Palindromes, PalindromeCheck));
    }

    public static void PalindromeCheck(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Output.Print(Message.NoInput);
            return;
        }
        input = input.ToLower();
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
        Output.Print((input.Length > 0) && (input == reversed) ? Message.IsPalindrome :
                                                                 Message.IsNotPalindrome);
    }
}