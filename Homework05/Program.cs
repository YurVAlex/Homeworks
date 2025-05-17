namespace Homework05;

public class Program
{
    static void Main(string[] args)
    {
        // Create a Book object using the default constructor:
        var book1 = new Book();
        Console.WriteLine("Книга 1 (значения по умолчанию):");
        Console.WriteLine(book1.GetDescription());

        // Use properties to set values:
        book1.Title = "Властелин колец";
        book1.Author = "Дж.Р.Р. Толкин";
        book1.Pages = 1178;

        Console.WriteLine("\nКнига 1 (после установки свойств):");
        Console.WriteLine(book1.GetDescription());

        // Create a Book object using the overloaded constructor:
        var book2 = new Book("Гордость и предубеждение", "Джейн Остин", 432);
        Console.WriteLine("\nКнига 2 (использована передача значений " +
                          "в перегруженный конструктор):");
        Console.WriteLine(book2.GetDescription());

        // Use properties to get values and print them directly:
        Console.Write("\nОписание книги 2:" +
                     $"\nНазвание: {book2.Title}" +
                     $"\nАвтор: {book2.Author}" +
                     $"\nСтраниц: {book2.Pages}\n");

        // Example of changing values:
        book2.Pages = 400;
        Console.WriteLine("\nКнига 2 (после изменения количества страниц):");
        Console.WriteLine(book2.GetDescription());

        // Create a Book object using initializer:
        var book3 = new Book
        {
            Author = "Джордж Оруэлл",
            Title = "1984",
            Pages = 328
        };
        Console.WriteLine("\nОписание книги 3:");
        Console.WriteLine(book3.GetDescription());

        // Example of changing values:
        book3.Title = "Скотный двор";
        book3.Pages = 92;
        Console.WriteLine("\nКнига 3 (после изменений):");
        Console.WriteLine(book3.GetDescription());
    }
}
