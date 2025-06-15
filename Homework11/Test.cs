namespace Homework11;

public class Test
{
    public static void Run()
    {
        Output.Important("--- Factorial Calculator Test ---");

        var cases = new[] { 4, 0, -5, 12, 16, 20, 35, 55, 170, 250 };

        foreach (var item in cases)
        {
            try
            {
                var currentResult = Factorial.Calculate(item);
                Console.WriteLine($"The factorial of {item} is: {currentResult}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Output.Error($"Error calculating factorial for {item}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Output.Error($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
