namespace Homework11;

public class FactorialTooBigArgumentException : ArgumentException
{
    public int MaxArgument { get; } = 170;

    /*public FactorialTooBigArgumentException(string paramName)
        : base(paramName, "Trying to calculate a factorial value that is too large.")
        { }*/

    public override string Message
    {
        get
        {
            return "Trying to calculate a factorial value that is too large.";
        }
    }
}
