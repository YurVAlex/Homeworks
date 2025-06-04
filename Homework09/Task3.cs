using System.Text;

namespace Homework09;

// This program allows to count the number of unique words in several paragraphs of text
public class Task3
{
    public static void Run()
    {
        var wordCounts = new Dictionary<string, int>();
        var toTrim = "!@#$%^&*()_+-=[]{}|;':\",./<>?`~1234567890 \t\n\r".ToCharArray();
        var separators = " \t\r\n".ToCharArray();
        var input = new StringBuilder();

        Console.WriteLine("Enter (or paste) text to count unique words:");
        do
        {
            input.AppendLine(Console.ReadLine());

        } while (Console.KeyAvailable);

        var words = input.ToString()
                         .ToLower()
                         .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                         .Select(word => word.Trim(toTrim))
                         .Where(word => !string.IsNullOrEmpty(word))
                         .ToArray();

        for (var i = 0; i < words.Length; i++)
        {
            var currentWord = words[i];

            if (wordCounts.ContainsKey(currentWord))
            {
                wordCounts[currentWord]++;
            }
            else
            {
                wordCounts[currentWord] = 1;
            }
        }

        if (wordCounts.Count > 0)
        {
            Console.WriteLine($"\nNumber of unique words: {wordCounts.Count}" +
                               "\nUnique words and their frequencies:");
            foreach (var item in wordCounts)
            {
                Console.WriteLine("{0,-25} {1,9}", $"{item.Key}:", $"{item.Value}");
            }
        }
        else
        {
            Console.WriteLine("No words entered!");
        }
    }
}