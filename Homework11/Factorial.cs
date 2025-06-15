namespace Homework11;

public class Factorial
{
    public static double Calculate(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), 
                "Factorial is not defined for negative numbers.");
        }
        else
        {
                return n * Calculate(n - 1);
        }
    }
}
