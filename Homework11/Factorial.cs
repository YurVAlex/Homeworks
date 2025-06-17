namespace Homework11;

public class Factorial
{
    private const int _maxArgument = 170; // Calculation for 171 returns "?" for double
                                          // Calculation for 21 will overflow long
    public static double Calculate(int n) // Stack overflow occurs after ~16K repeatings
    {
        return n switch
        {
            < 0 or > _maxArgument => throw new FactorialArgumentException(n, _maxArgument),
            < 2 => 1,
            _ => n * Calculate(n - 1)
        };
    }
}