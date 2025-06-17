namespace Homework11;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- FACTORIAL CALCULATOR TEST ---");

        var cases = new[] { -1, 0, 1, 5, 12, 25, 55, 100, 170, 250 };

        foreach (var item in cases)
        {
            try
            {
                var currentResult = Factorial.Calculate(item);
                Console.WriteLine($"The factorial of {item} is: {currentResult}");
            }
            catch (FactorialArgumentException ex)
            {
                Output.Error($"Error calculating factorial for {item}:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                Output.Error($"An unexpected error occurred: {ex.Message}");
            }
        }
        Output.Finish();
    }
}