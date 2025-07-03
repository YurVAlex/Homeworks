namespace Homework13;

public class NewsProvider(string name)
{
    public string Name { get; set; } = (!string.IsNullOrEmpty(name)) ? name : "Unknown";

    public event EventHandler<NewsEventArgs>? NewsPublished;

    public void Publish(Category category, string message)
    {
        NewsPublished?.Invoke(this, new NewsEventArgs(category, message));
    }
}