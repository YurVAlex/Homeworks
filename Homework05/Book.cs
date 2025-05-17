namespace Homework05;

public class Book
{
    private string _title;
    private string _author;
    private int _pages;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Pages
    {
        get { return _pages; }
        set
        {
            if (value > 0)
            {
                _pages = value;
            }
            else
            {
                _pages = 0;
            }
        }
    }

    public Book()
    {
        _title = "Unknown";
        _author = "Unknown";
        _pages = 0;
    }

    public Book(string title, string author, int pages)
    {
        _title = title;
        _author = author;
        _pages = pages;
    }

    public string GetDescription()
    {
        return $"Название: {_title}, Автор: {_author}, Страниц: {_pages}";
    }
}