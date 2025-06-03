namespace Homework09;

public class Task3
{
    public static void Run()
    {
        Dictionary<string, int> wordCounts = [];

        Console.WriteLine("Please, enter some text to count unique words:");
        var input = Console.ReadLine();

        char[] toTrim = "!@#$%^&*()_+-=[]{}|;':\",./<>?`~1234567890 \t\n\r".ToCharArray();

        var words = input.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (var i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Trim(toTrim);

            if (wordCounts.ContainsKey(words[i]))
            {
                wordCounts[words[i]]++;
            }
            else
            {
                wordCounts[words[i]] = 1;
            }
        }
        if (wordCounts.Count > 0)
        {
            Console.WriteLine($"\nNumber of unique words: {wordCounts.Count}" +
                               "\nUnique words and their frequencies:");
            foreach (var item in wordCounts)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        else
        {
            Console.WriteLine("No words entered!");
        }
    }
}