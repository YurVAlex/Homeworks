namespace Homework13;

public class NewsEventArgs(Category category, string message) : EventArgs
{
    public Category Category { get; } = category;
    public string Message { get; } = message;
}