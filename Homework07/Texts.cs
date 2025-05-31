using System;

namespace Homework07;

public static class Texts
{
    public static Dictionary<Enum, string> Headers { get; } = new()
    {
        { Header.PalindromeTask, "Checking a string for a palindrome" },
        { Header.CombineTask, "" },
    };

    public static Dictionary<Enum, string> Messages { get; } = new()
    {
        { Message.NoInput, "No input provided" },
        { Message.IsPalindrome, "Yes, the entered string is a palindrome" },
        { Message.IsNotPalindrome, "No, the entered string is not a palindrome" },
        { Message.ErrorOutput, "Error output request" },
    };

    public static Dictionary<Enum, string> Prompts { get; } = new()
    {
        { Prompt.UserInput, "Please enter some text" },
        { Prompt.Exit, "To move to the next task, enter \"exit\"\n" },
        { Prompt.EngageTest, "To run the test case, enter \"run\"" },
        { Prompt.PressKey, "Press any key to continue..." },
    };

    public static string GetText(Enum key, Dictionary<Enum, string> set)
    {
        return set.TryGetValue(key, out var value) ? value : string.Empty;
    }

}
