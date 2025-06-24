namespace Homework13;

public class NewsProvider(string name)
{
    private Dictionary<Category, List<Action<string>>> _dealCatalog = [];

    public string Name { get; set; } = (!string.IsNullOrEmpty(name)) ? name : "Unknown";

    public void Subscribe(Category category, Action<string> dispatch)
    {
        if (!_dealCatalog.ContainsKey(category))
        {
            _dealCatalog[category] = [];
        }

        _dealCatalog[category].Add(dispatch);
    }

    public void Notify(Category category, string message)
    {
        if (_dealCatalog.TryGetValue(category, out var dispatches))
        {
            dispatches.ForEach(_ => _.Invoke(message));
        }
    }
}