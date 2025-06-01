namespace Homework07;

public class Task2
{
    public static void Run()
    {
        int[,] array = new int[3, 3];
        int[] rowMaximums = new int[array.GetLength(0)];

        var rnd = new Random();

        Console.WriteLine("Two-dimensional array with randomly generated values:\n");

        for (var i = 0; i < array.GetLength(0); i++) 
        {
            var maxInRow = int.MinValue; 

            for (var j = 0; j < array.GetLength(1); j++) 
            {
                array[i, j] = rnd.Next(1, 101);

                Console.Write($"{array[i, j]}\t"); 

                if (array[i, j] > maxInRow)
                {
                    maxInRow = array[i, j]; 
                }
            }
            Console.WriteLine();

            rowMaximums[i] = maxInRow;
        }

        Console.WriteLine("\nRow maximums:\n");

        for (int i = 0; i < rowMaximums.Length; i++)
        {
            Console.WriteLine($"Row {i}: {rowMaximums[i]}");
        }

        Console.WriteLine("\nPress any key to finish this task...");
        Console.ReadKey();
    }
}
