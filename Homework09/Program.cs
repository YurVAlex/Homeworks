namespace Homework09;

public class Program
{
    static void Main(string[] args)
    {
        Task1.Run();

        GoToNext();

        Task2.Run();

        GoToNext();
    }

    public static void GoToNext()
    {
        Console.WriteLine("\nTo move to the next task, press any key...");
        Console.ReadKey();
        Console.Clear();
    }
}

/*Задание 3:
Напишите программу, которая считает количество уникальных слов в тексте.
Считайте текст из строки (ввод с клавиатуры).
Используйте Dictionary<string, int> для подсчета частоты каждого слова.
Выведите уникальные слова и их количество.*/
