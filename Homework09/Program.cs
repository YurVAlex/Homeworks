namespace Homework09;

public class Program
{
    static void Main(string[] args)
    {
        List<Student> students =
        [
            new Student("Ivan", 20, 9.1),
            new Student("Kenny", 18, 8.7),
            new Student("Alex", 19, 7.9),
        ];

        students.Add(new Student("Lola", 18, 9.5));
        students.Add(new Student("Karabas", 20, 7.8));
        students.Add(new Student("Barabas", 20, 7.7));
        students.Add(new Student("", 22, 9.9));

        var sortedByMark = students.OrderByDescending(student => student.AverageMark).ToList();

        Console.WriteLine("Students sorted by Average Mark (highest to lowest):");
        Console.WriteLine(string.Join("\n", sortedByMark));
        
        var minAge = students.Min(student => student.Age);
        var youngestStudents = students.Where(student => student.Age == minAge);

        Console.WriteLine("\nYoungest student(s):");
        Console.WriteLine(string.Join("\n", youngestStudents));
    }

    /*Создайте словарь, где ключом является название продукта, а значением — его цена.
    Добавьте в словарь несколько продуктов.
    Выведите список всех продуктов с ценами.
    Реализуйте поиск продукта по названию (ввод названия с клавиатуры). 
    Если продукт найден, выведите его цену, иначе сообщите, что продукт отсутствует.
    Увеличьте цену всех продуктов на 10% и выведите на консоль.*/


}
