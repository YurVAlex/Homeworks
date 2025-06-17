namespace Homework11;

public class FactorialArgumentException(int argument, int bound) : ArgumentException
{
    public override string Message
    {
        get
        {
            return (argument < 0) ? "Factorial is not defined for negative numbers.":
                "Trying to calculate a factorial value that is too large.\n" +
                $"Max number for calculation: {bound}.";
        }
    }
}