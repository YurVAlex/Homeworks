namespace Homework07;

public class Task1
{
    public static void Run()
    {
        int[] numbers = new int[6];

        Console.WriteLine("Enter 6 integers for the array elements:\n");
        for (var i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("\nIncorrect input. Please enter an integer.\n");
                i--;
            }
        }
        Console.WriteLine("\nArray elements entered:\n");
        Console.WriteLine(string.Join(" ", numbers));

        Array.Sort(numbers);
        Array.Reverse(numbers);

        Console.WriteLine("\nArray elements sorted in descending order:\n");
        Console.WriteLine(string.Join(" ", numbers));

        Console.WriteLine("\nPress any key to finish this task...\n");
        Console.ReadKey();
        Console.Clear();
    }
}
