namespace Homework06;

public class Manager(string name, string position) : EmployeeBase(name, position)
{
    public List<Project> Projects { get; set; } = [];

    public override void GetDetails()
    {
        string projects = string.Empty;

        foreach (var project in Projects)
        {
            projects += project.Name + "\n";
        }

        Console.WriteLine($"{this.GetType} {Name}, current projects: \n{projects}");
    }
}
