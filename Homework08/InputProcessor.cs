namespace Homework08;

public class InputProcessor
{
    public static bool IsActive(string input, List<string> testCase, Action<string> process)
    {
        switch (input.ToLower())
        {
            case "exit":
            {
                Console.Clear();
                return false;
            }
            case "run":
            {
                Test.Run(testCase, process);
                break;
            }
            default:
            {
                process(input);

                Output.PressAndClear();
                break;
            }
        }
        return true;
    }
}
