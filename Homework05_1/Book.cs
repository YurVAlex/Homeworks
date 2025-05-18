namespace Homework05_1;

class Book(string title = "Unknown", string author = "Unknown", int pages = 0)
{
    public string Title { get; set; } = title;

    public string Author { get; set; } = author;

    public int Pages { get; set; } = pages;

    public string GetDescription() =>
        $"Название: {Title}, Автор: {Author}, Страниц: {Pages}";
}