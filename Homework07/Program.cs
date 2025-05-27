namespace Homework07;

public class Program
{
    static void Main(string[] args)
    {
        Task1();



    }

    public static void Task1()
    {
        string newPromptMessage = "Enter text to check if a string is a palindrome. \n",
               noInputPromptMessage = "No input provided. Please enter some text. \n",
               exitPromptMessage = "To move to next task enter \"next\"\n",
               isPalindromeMessage = "The entered string is a palindrome!",
               isNotPalindromeMessage = "The entered string is not a palindrome!",
               userInput = string.Empty; // To enum this

        while (userInput != "exit")
        {
            ShowMessage("Task 1 - palindrome string check!");
            Console.Write(newPromptMessage + exitPromptMessage);

            userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "exit":
                    {
                        return;
                    }
                case "":
                    {
                        Console.Write(noInputPromptMessage + exitPromptMessage);
                        continue;
                    }
                default:
                    {
                        for (int i = 0; i < userInput.Length; i++)
                        {
                            if (!char.IsLetter(userInput[i]))
                            {
                                userInput = userInput.Remove(i,1);
                            }
                        }

                        Console.Write(userInput.Equals(userInput.Reverse()) ? isPalindromeMessage
                                                                            : isNotPalindromeMessage);
                        continue;
                    }
            }




        }


    }

    public static void ShowMessage(string message)
    {
        Console.WriteLine($"---=== {message} ===---\n");
    }
}
