namespace Homework04;

class Program
{
    static void Main(string[] args)
    {
        Task1();
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

        Console.ReadKey();
    }
}
