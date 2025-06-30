namespace Homework08;

public class Output
{
    public static void Print(Enum key)
    {
        Console.WriteLine(key switch
        {
            Header => $"\n--== {Texts.GetText(key, Texts.Headers).ToUpper()} ==--\n",
            Message => $"{Texts.GetText(key, Texts.Messages)}\n",
            Prompt => $"-> {Texts.GetText(key, Texts.Prompts)}",
            _ => $"{Texts.GetText(Message.ErrorOutput, Texts.Messages)}!"
        });
    }

    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static void PressAndClear()
    {
        Print(Prompt.PressKey);
        Console.SetCursorPosition(0, 0);
        Console.ReadKey();
        Console.Clear();
    }
}
