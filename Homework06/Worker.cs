using static Homework06.Manager;

namespace Homework06;

public class Worker(string name, string position) : EmployeeBase(name, position) // make internal?
{
    public List<string> Skills { get; set; } // params?

    public override void GetDetails()
    {
        Console.WriteLine($"\nWorker ({Position}): {Name}.\nHas skills:\n");

        if (Skills.Count > 0)
        {
            foreach (var skill in Skills)
            {
                Console.WriteLine(skill);
            }
        }
        else
        {
            Console.WriteLine("No skills data.");
        }
    }
}
