namespace Homework06;

public class Manager(string name, string position) : EmployeeBase(name, position)
{
    public List<Project> Projects { get; set; } = [];

    public override void GetDetails()
    {
        Console.WriteLine($"\nManager ({Position}): {Name}.\nCurrent projects:\n");

        if (Projects.Count > 0)
        {
            foreach (var project in Projects)
            {
                project.DisplayProjectInfo();
            }
        }
        else
        {
            Console.WriteLine("No current projects.");
        }
    }

    public class Project(string name = "Noname", DateOnly deadline = default)
    {
        public string ProjectName { get; set; } = name;

        public DateOnly Deadline { get; set; } = deadline;

        public void DisplayProjectInfo()
        {
            Console.WriteLine($"{ProjectName}, deadline: {Deadline}");
        }
    }
}
