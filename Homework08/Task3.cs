namespace Homework08;

public class Task3
{
    public static void Run()
    {
        do
        {
            Output.Print(Header.VariousCasesTask);
            Output.Print(Prompt.UserInput);
            Output.Print(Prompt.EngageTest);
            Output.Print(Prompt.Exit);

        } while (InputProcessor.IsActive(Console.ReadLine(), TestCases.VariousCases, ChangeСase));
    }

    static string ToUpperFirstChars(string input)
    {
        char[] result = input.ToCharArray();
        var newWordFlag = true;

        for (var i = 0; i < result.Length; i++)
        {
            if (char.IsWhiteSpace(result[i]) || result[i] == '\t' || result[i] == '\n')
            {
                newWordFlag = true;
            }
            else if (newWordFlag && char.IsLetter(result[i]))
            {
                result[i] = char.ToUpper(result[i]);
                newWordFlag = false;
            }
            else
            {
                newWordFlag = false;
            }
        }
        return new string(result);
    }

    public static void ChangeСase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Output.Print(Message.NoInput);
            return;
        }
        Output.Print(Message.ResultPromise);
        Output.Print($"All lowercase: {input.ToLower()}\nAll caps: {input.ToUpper()}" +
                     $"\nThe first letter of each word is capitalized: {ToUpperFirstChars(input)}\n");
    }
}
