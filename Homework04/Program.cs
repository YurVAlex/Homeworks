using System;

namespace Homework04;

class Program
{
    static void Main(string[] args)
    {
        Task1();

        SkipToNext();

        Task2();

        SkipToNext();

        Task3();

        SkipToNext();
    }

    static void Task1()
    {
        int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int index; // common to loops

        Console.WriteLine("Iterating through an array using " +
                          "\"for\" control flow statement" +
                          "\n(explicit iteration control):");

        for (index = 0; index < numbers.Length;)
            Console.Write(numbers[index++] + " ");

        Console.WriteLine("\n\nIterating through an array using " +
                          "\"do - while\" control flow statement" +
                          "\n(cycle with postcondition check):");

        do Console.Write(numbers[--index] + " ");
        while (index > 0);

        Console.WriteLine("\n\nIterating through an array using " +
                          "\"while\" control flow statement" +
                          "\n(cycle with precondition check):");

        while (index < numbers.Length)
            Console.Write(numbers[index++] + " ");

        Console.WriteLine("\n\nIterating through an array using " +
                          "\"foreach\" control flow statement" +
                          "\n(collection-based iteration):");

        foreach (var number in numbers)
            Console.Write(number + " ");
    }

    static void Task2()
    {
        Console.WriteLine("All two-digit numbers multiples of 5" +
                          " including negative double digits:");

        for (int i = -95; i < 96; i += 5)
        {
            if (i <= -10 || i >= 10)
                Console.Write(i + " ");
        }
    }

    static void Task3()
    {
        var number = 0;

        Console.WriteLine("Sequence of numbers -20, -40, ..., -100 in column:");

        do Console.WriteLine(number -= 20);
        while (number > -100);
    }

    static void SkipToNext()
    {
        Console.Write("\n\nTo continue, press any key");
        Console.ReadKey();
        Console.Clear();
    }
}
