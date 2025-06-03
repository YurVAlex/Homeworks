namespace Homework08;

public static class Texts
{
    public static Dictionary<Enum, string> Headers { get; } = new()
    {
        { Header.PalindromeTask, "Checking a string for a palindrome" },
        { Header.CombineTask, "Remove spaces in a line" },
        { Header.TestCase, "A set of test strings has been launched" },
        { Header.VariousCasesTask, "Changing the case of letters in words" }
    };

    public static Dictionary<Enum, string> Messages { get; } = new()
    {
        { Message.NoInput, "\nNo input provided!" },
        { Message.PalinromeWiki, "A palindrome is a number, letter combination," +
            "\nword or text that reads the same in both directions." },
        { Message.IsPalindrome, "\nYES, the entered string is a palindrome!" },
        { Message.IsNotPalindrome, "\nProvided input is NOT a palindrome!" },
        { Message.ErrorOutput, "\nError output request." },
        { Message.ItemPromise, "Case under test: " },
        { Message.ResultPromise, "\nThe result is: " }
    };      

    public static Dictionary<Enum, string> Prompts { get; } = new()
    {
        { Prompt.UserInput, "Please enter some text" },
        { Prompt.Exit, "To move to the next task, enter \"exit\"\n" },
        { Prompt.EngageTest, "To run the test case, enter \"run\"" },
        { Prompt.PressKey, "Press any key to continue..." }
    };

    public static string GetText(Enum key, Dictionary<Enum, string> set)
    {
        return set.TryGetValue(key, out var value) ? value : string.Empty;
    }
}
