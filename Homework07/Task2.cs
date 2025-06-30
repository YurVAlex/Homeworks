namespace Homework07;

public class Task2
{
    public static void Run()
    {
        int[,] array = new int[3, 3];
        var rowMaximums = "\n";
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

            rowMaximums += $"Maхimum in {i} row: {maxInRow}\n";
        }
        Console.WriteLine(rowMaximums);

        Console.WriteLine("\nPress any key to finish this task...");
        Console.ReadKey();
    }
}
