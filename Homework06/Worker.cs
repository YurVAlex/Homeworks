namespace Homework06;

public class Worker(string name, string position, params string[] skills) :
             EmployeeBase(name, position)
{
    // List of worker's skills, initialized from constructor arguments
    public List<string> Skills { get; set; } = [.. skills];

    public override void GetDetails()
    {
        Console.Write($"\nWorker ({Position}): {Name}.\n");

        DisplayAllSkills();
    }

    public void AddSkill(string skill)
    {
        Skills.Add(skill);
    }

    public void RemoveSkill(string skill)
    {
        Skills.Remove(skill);
    }

    public void DisplayAllSkills()
    {
        var message = Skills.Count switch
        {
            0 => "No skills data.",
            1 => $"Has skill:\n{Skills[0]}",
            _ => $"Has skills:\n{string.Join("\n", Skills)}"
        };

        Console.WriteLine(message);
    }
}
