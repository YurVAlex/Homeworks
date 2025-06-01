namespace Homework07;

public class Task2
{
    public static void Run()
    {
        int[,] matrix = {
            { 555, 34, -77 },  
            { 23, 777, -15 },  
            { -67, 55, 999 }   
        };

        Console.WriteLine("Two-dimensional array:");

        for (var i = 0; i < matrix.GetLength(0); i++) 
        {
            for (var j = 0; j < matrix.GetLength(1); j++) 
            {
                Console.Write($"{matrix[i, j]}\t"); 
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nMaximum elements of each row:");

        for (var i = 0; i < matrix.GetLength(0); i++) 
        {
            var maxInRow = matrix[i, 0]; 

            for (var j = 1; j < matrix.GetLength(1); j++) 
            {
                if (matrix[i, j] > maxInRow)
                {
                    maxInRow = matrix[i, j]; 
                }
            }
            Console.WriteLine($"Line {i}: {maxInRow}");
        }

        Console.WriteLine("\nPress any key to finish this task...");
        Console.ReadKey();
    }
}
