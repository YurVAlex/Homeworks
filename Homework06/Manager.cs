namespace Homework06;

public class Manager(string name, string position) : EmployeeBase(name, position)
{
    public List<Project> Projects { get; set; } = [];

    public override void GetDetails()
    {
        Console.Write($"\nManager ({Position}): {Name}.\n\n");

        DisplayAllProjects();
    }

    public void AddProject(Project project)
    {
        Projects.Add(project);
    }

    public void AddProject(string project)
    {
        var marker = project.IndexOf(',');

        Projects.Add(marker == -1 ?
                     new Project(project) :
                     new Project(project[..marker], project[marker..]));
    }

    public void DeleteProject(string projectName)
    {
        var temp = Projects.Find(_ => _.ProjectName == projectName);

        if (temp != null)
        {
            Projects.Remove(temp);
            Console.Write($"Project {temp.ProjectName} deleted.\n");
        }
        else
        {
            Console.Write($"Error. Project \"{temp}\" not found.\n");
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

    public void DisplayAllProjects()
    {
        if (Projects.Count == 0)
        {
            Console.Write("No projects assigned.\n");
        }
        else
        {
            var message = Projects.Count > 1 ? "Current projects:" :
                                               "Current project:";
            Console.WriteLine(message);

            Projects.ForEach(project => project.DisplayProjectInfo());
        }
    }
}
