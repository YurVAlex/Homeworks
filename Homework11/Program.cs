namespace Homework11;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Factorial Calculator Test ---\n");

        var cases = new[] { 4, 0, -5, 12, 16, 20, 35, 55, 170, 250 };

        foreach (var item in cases)
        {
            try
            {
                var currentResult = Factorial.Calculate(item);
                Console.WriteLine($"The factorial of {item} is: {currentResult}");
            }
            catch (FactorialTooBigArgumentException ex)
            {
                Output.Error($"Error calculating factorial for {item}:" +
                             $"\n{ex.Message}" +
                             $"\nRange of numbers for calculation: 0 - {ex.MaxArgument}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Output.Error($"Error calculating factorial for {item}:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                Output.Error($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
