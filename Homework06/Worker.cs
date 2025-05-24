namespace Homework06;

public class Worker(string name, string position, params string[] skills) :
             EmployeeBase(name, position)
{
    public List<string> Skills { get; set; } = new List<string>(skills) ?? [];

    public override void GetDetails()
    {
        Console.Write($"\nWorker ({Position}): {Name}.\n\n");

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
        if (Skills.Count == 0)
        {
            Console.Write("No skills data.\n");
        }
        else if (Skills.Count == 1)
        {
            Console.Write($"Has skill:\n{Skills[0]}\n");
        }
        else
        {
            Console.Write("Has skills:\n");
            Skills.Sort();
            Skills.ForEach(skill => Console.WriteLine(skill));
        }
    }
}
