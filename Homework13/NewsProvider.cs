namespace Homework13;

public class NewsProvider(string name)
{
    private Dictionary<Category, List<Action<string>>> _dealCatalog = [];

    public string Name { get; set; } = (!string.IsNullOrEmpty(name)) ? name : "Unknown";

    public event EventHandler<NewsEventArgs>? NewsPublished;

    public void Notify(Category category, string message)
    {
        OnNewsPublished(new NewsEventArgs(category, message));
    }

    protected virtual void OnNewsPublished(NewsEventArgs e)
    {
        NewsPublished?.Invoke(this, e);
    }
}