namespace Homework02;

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
        double height;

        Console.Write("Введите ваше имя: ");
        var name = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.Write("Ошибка ввода. Введите целое не отрицательное число: ");
        }

        Console.Write("Введите ваш рост (в метрах, например 1,75): ");
        while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            // TODO - add delimiter type check
            Console.Write("Ошибка ввода. Введите число (например 1,75): ");
        }

        Console.WriteLine($"\nПривет, {name}!");
        Console.WriteLine($"\tВаш возраст: {age} лет.");
        Console.WriteLine($"\t\tВаш рост: {height} м.");
    }

    static void Task2()
    {
        double operand1, operand2;

        Console.WriteLine("\nВведите первое число:");
        while (!double.TryParse(Console.ReadLine(), out operand1))
        {
            Console.WriteLine("Ошибка ввода. Введите первое число:");
        }

        Console.WriteLine("Введите второе число:");
        while (!double.TryParse(Console.ReadLine(), out operand2))
        {
            Console.WriteLine("Ошибка ввода. Введите второе число:");
        }

        var sum = operand1 + operand2;
        var difference1 = operand1 - operand2;
        var difference2 = operand2 - operand1;
        var product = operand1 * operand2;
        var quotient1 = Quotient(operand1, operand2);
        var quotient2 = Quotient(operand2, operand1);

        var resultsBlock = $"""
        Сумма двух чисел:      {sum}
        Разность числа 1 и 2:  {difference1}
        Разность числа 2 и 1:  {difference2}
        Произведение чисел:    {product}
        Частное числа 1 и 2:   {quotient1}
        Частное числа 2 и 1:   {quotient2}
        """;

        Console.WriteLine(resultsBlock);
    }
    static string Quotient(double value1, double value2)
    {
        return (value2 != 0) ?
            (value1 / value2).ToString() :
            "Попытка деления на 0!";
    }
}

