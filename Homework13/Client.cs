namespace Homework13;

public class Client
{
    private string _name;
    private string _id = Guid.NewGuid().ToString();

    private Dictionary<NewsProvider, List<Category>> _subscriptionCatalog = [];

    public Client(string name, NewsProvider provider, params Category[] categories)
    {
        _name = (!string.IsNullOrEmpty(name)) ? name : "Default";
        
        AddSubscriptions(provider, categories);
    }

    public void AddSubscriptions(NewsProvider provider, params Category[] categories)
    {
        if (!_subscriptionCatalog.ContainsKey(provider))
        {
            _subscriptionCatalog[provider] = [];
        }

        if (categories.Length == 0)
        {
            categories = Enum.GetValues<Category>();
        }

        foreach (var category in categories)
        {
            if (!_subscriptionCatalog[provider].Contains(category))
            {
                _subscriptionCatalog[provider].Add(category);

                provider.Subscribe(category, message =>
                    Console.WriteLine($"Id: {_id}({_name}) receives: {message}"));
            }
        }
    }
}
