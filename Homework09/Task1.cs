namespace Homework09;

public class Task1
{
    public static void Run()
    {
        var students = new List<Student>
        {
            new("Ivan", 20, 9.1),
            new("Kenny", 18, 8.7),
            new("Alex", 19, 7.9),
            new("Lola", 18, 9.5)
        };
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
}
