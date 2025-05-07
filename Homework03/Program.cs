namespace Homework03;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Task1();
        }
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
}
