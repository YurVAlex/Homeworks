namespace Homework07;

public class Output
{
    public static void Print(Enum key)
    {
        Console.WriteLine(key switch
        {
            Header => $"\n--== {Texts.GetText(key, Texts.Headers).ToUpper()} ==--\n",
            Message => $"\n{Texts.GetText(key, Texts.Messages)}!\n",
            Prompt => $"-> {Texts.GetText(key, Texts.Prompts)}",
            _ => $"{Texts.GetText(Message.ErrorOutput, Texts.Messages)}!"
        });
    }
}
