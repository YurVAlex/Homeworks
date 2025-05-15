namespace Homework04;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }

    static void Task1()
    {
        int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int index; // common to loops

        Console.WriteLine("Iterating through an array using " +
                          "\"for\" control flow statement" +
                          "\n(explicit iteration control):");

        for (index = 0; index < numbers.Length;)
        {
            Console.Write(numbers[index++] + " ");
        }

        Console.WriteLine("\n\nIterating through an array using " +
                          "\"do - while\" control flow statement" +
                          "\n(cycle with postcondition check):");

        do
        {
            Console.Write(numbers[--index] + " ");
        } while (index > 0);

        Console.WriteLine("\n\nIterating through an array using " +
                          "\"while\" control flow statement" +
                          "\n(cycle with precondition check):");

        while (index < numbers.Length)
        {
            Console.Write(numbers[index++] + " ");
        }

        Console.WriteLine("\n\nIterating through an array using " +
                          "\"foreach\" control flow statement" +
                          "\n(collection-based iteration):");

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        SkipToNext();
    }

    static void Task2()
    {
        Console.Write("All two-digit numbers multiples of 5" +
                      " (including negative double digits):\n");

        for (int i = -95; i < 96; i += 5)
        {
            if (i < -9 || i > 9)
            {
                Console.Write(i + " ");
            }
        }

        SkipToNext();
    }

    static void Task3()
    {
        var number = 0;

        Console.Write("Sequence of numbers -20, -40, ..., -100:\n\n");

        do
        {
            Console.WriteLine(number -= 20);
        } while (number > -100);

        SkipToNext();
    }

    static void Task4()
    {
        string userInput;

        while (true)
        {
            Console.WriteLine("Пожалуйста, введите символ:");
            userInput = Console.ReadLine().ToLower();

            var result = userInput switch
            {
                "w" => "Фигура перемещена вверх\n",
                "s" => "Фигура перемещена вниз\n",
                "a" => "Фигура перемещена влево\n",
                "d" => "Фигура перемещена вправо\n",
                _ => "Фигура не перемещена\n"
            };

            Console.WriteLine(result);
        }
    }

    static void SkipToNext()
    {
        Console.Write("\n\nTo continue, press any key");
        Console.ReadKey();
        Console.Clear();
    }
}
