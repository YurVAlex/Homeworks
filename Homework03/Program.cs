namespace Homework03;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
    }

    static void Task1()
    {
        int age;

        Console.WriteLine("Пожалуйста введите ваш возраст:");
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.WriteLine("Ошибка ввода. Введите целое, положительное число:");
        }

        var result = age switch
        {
            >= 0 and < 3 => "Вы младенец.",
            >= 3 and < 13 => "Вы ребёнок.",
            >= 13 and < 18 => "Вы подросток.",
            >= 60 => "Вы пожилой.",
            _ => "Вы взрослый."
        };

        result += (age % 2 == 0) ?
            " Ваш возраст - число чётное." :
            " Ваш возраст - число нечётное.";

        Console.WriteLine(result);
    }

    static void Task2()
    {
        bool[] bools = new bool[6];

        var columnWidth = 14;
        var results = string.Empty;
        var formatedTrue = "true".PadRight(columnWidth);
        var formatedFalse = "false".PadRight(columnWidth);

        BoolInput("\nPlease enter the first boolean value:", out bools[0]);
        BoolInput("Please enter the second boolean value:", out bools[1]);

        bools[2] = bools[0] & bools[1];
        bools[3] = bools[0] | bools[1];
        bools[4] = bools[0] ^ bools[1];
        bools[5] = !bools[0];

        foreach (bool current in bools)
        {
            results += current ? formatedTrue : formatedFalse;
        }

        var resultBlock = $"""
        ------------------------------------------------------------------------------------
        |      p      |      q      |    p & q    |    p | q    |    p ^ q    |     !p     |
        ------------------------------------------------------------------------------------
             {results} 
        """;

        Console.WriteLine(resultBlock);
    }

    static void BoolInput(string message, out bool value)
    {
        Console.WriteLine(message);

        while (!bool.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Input error. Please enter a boolean " +
                              "value (eg \"true\" or \"false\"):");
        }
    }
}
