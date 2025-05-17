namespace Homework05_1;

public class Program
{
    static void Main(string[] args)
    {
        // Create a Book object using defaults in the primary constructor:
        var book1 = new Book();

        ShowInfo("Книга 1 (использованы значения по умолчанию):", book1);

        // Use properties to set values:
        book1.Title = "Властелин колец";
        book1.Author = "Дж.Р.Р. Толкин";
        book1.Pages = 1178;

        ShowInfo("\nКнига 1 (после установки свойств):", book1);

        // Create a Book object using values in primary constructor:
        var book2 = new Book("Гордость и предубеждение", "Джейн Остин", 432);

        ShowInfo("\nКнига 2 (использованы заданные значения):", book2);

        // Use properties to get values and print them directly:
        Console.Write("\nОписание книги 2:" +
                     $"\nНазвание: {book2.Title}" +
                     $"\nАвтор: {book2.Author}" +
                     $"\nСтраниц: {book2.Pages}\n");

        // Example of changing values:
        book2.Pages = 400;

        ShowInfo("\nКнига 2 (после изменения количества страниц):", book2);

        // Create a Book object using initializer:
        var book3 = new Book
        {
            Author = "Джордж Оруэлл",
            Title = "1984",
            Pages = 328
        };

        ShowInfo("\nОписание книги 3:", book3);

        // Example of changing values:
        book3.Title = "Скотный двор";
        book3.Pages = 92;

        ShowInfo("\nКнига 3 (после изменений):", book3);
    }

    static void ShowInfo(string message, Book book)
    {
        Console.WriteLine(message);
        Console.WriteLine(book.GetDescription());
    }
}