namespace Homework04;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
    }

    static void Task1()
    {
        int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int index; // common for index-based loops

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
        Console.WriteLine("\n\nAll two-digit numbers multiples of 5:");

        for (int i = -95; i < 96; i += 5)
            Console.Write(i + " ");
    }

    static void Task3()
    {
        Console.WriteLine("\n\nSequence of numbers -20, -40, ..., -100 " +
                          "using cycle with postcondition check:");

        for (int i = -20; i >= -100; i -= 20)
            Console.WriteLine(i);
    }
}
