namespace Homework06;

public class Manager(string name, string position, int experience = 0) :
             EmployeeBase(name, position)
{
    public int Experience { get; set; } = experience;

    // List of projects the manager is responsible for
    public List<Project> Projects { get; set; } = [];

    public override void GetDetails()
    {
        Console.Write($"\nManager ({Position}): {Name}. Experience: " +
                      $"{Experience} year{(Experience == 1 ? "" : "s")}.\n");

        DisplayAllProjects();
    }

    public void AddProject(Project project)
    {
        Projects.Add(project);
    }

    // Overloaded version
    // Adds a project (by string, comma-separated)
    // If the string contains a comma, splits into name and deadline
    public void AddProject(string project)
    {
        var marker = project.IndexOf(',');

        Projects.Add(marker == -1 ?
                     new Project(project) :
                     new Project(project[..marker], project[(marker + 1)..].Trim()));
    }

    public void DeleteProject(string projectName)
    {
        var temp = Projects.Find(_ => _.ProjectName == projectName);

        if (temp != null)
        {
            Projects.Remove(temp);
            Console.Write($"Project \"{projectName}\" deleted.\n");
        }
        else
        {
            Console.Write($"Error. Project \"{projectName}\" not found.\n");
        }
    }

    public class Project(string name = "Noname", string deadline = "Not defined")
    {
        public string ProjectName { get; set; } = name;

        public string Deadline { get; set; } = deadline;

        public void DisplayProjectInfo()
        {
            Console.Write($"{ProjectName}, deadline: {Deadline}\n");
        }
    }

    // Displays all projects assigned to the manager
    public void DisplayAllProjects()
    {
        if (Projects.Count == 0)
        {
            Console.Write("No projects assigned.\n");
        }
        else
        {
            Console.Write($"Project{(Projects.Count == 1 ? "" : "s")}:\n");

            Projects.ForEach(project => project.DisplayProjectInfo());
        }
    }
}
