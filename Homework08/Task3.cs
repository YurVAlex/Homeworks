namespace Homework08;

public class Task3
{
    public static void Run()
    {
        while (true)
        {
            Output.Print(Header.VariousCasesTask);
            Output.Print(Prompt.UserInput);
            Output.Print(Prompt.EngageTest);
            Output.Print(Prompt.Exit);

            var userInput = Console.ReadLine();

            var lowerCase = userInput.ToLower();
            var upperCase = userInput.ToUpper();
            var upperFirstChars = ToUpperFirstChars(userInput);

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
                        Output.Print(Message.ResultPromise);
                        Output.Print($"All lowercase: {lowerCase}\nAll caps: {upperCase}" +
                            $"\nThe first letter of each word is capitalized: {upperFirstChars}\n");

                        Output.PressAndClear();
                        break;
                    }
            }
        }
    }

    static string ToUpperFirstChars(string str)
    {
        char[] result = str.ToLower().ToCharArray();
        bool newWordFlag = true;

        for (int i = 0; i < result.Length; i++)
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

    public static void EngageTest()
    {
        Console.Clear();
        Output.Print(Header.TestCase);

        foreach (var item in TestCases.VariousCases)
        {
            Output.Print(Message.ItemPromise);
            Output.Print(item + "\n");

            if (string.IsNullOrEmpty(item))
            {
                Output.Print(Message.NoInput);
                continue;
            }

            Output.Print(Message.ResultPromise);
            Output.Print($"Все строчные: {item.ToLower()}\nВсе заглавные: {item.ToUpper()}" +
                         $"\nПервая буква каждого слова c заглавной: {ToUpperFirstChars(item)}\n");
        }
        Output.PressAndClear();
    }
}
